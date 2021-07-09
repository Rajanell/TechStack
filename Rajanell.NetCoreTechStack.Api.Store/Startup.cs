using IdentityServer4.AccessTokenValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Rajanell.TechStack.API.Store.DIServices;
using Rajanell.TechStack.API.Store.Filters;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Infrastructure.Data;
using Rajanell.TechStack.Services.EventHandlers;
using Rajanell.TechStack.Services.EventHandlers.Commands;
using Rajanell.TechStack.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Rajanell.TechStack.Validation.Validators;
using Rajanell.TechStack.Core.Service;
using Rajanell.TechStack.Phonebook.Infrastructure.Data;
using Rajanell.TechStack.Phonebook.Services.EventHandlers;

namespace Rajanell.NetCoreTechStack.Api.Store
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(options => options.Filters.Add<ValidationFilter>()).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddUserValidator>())
                     //.AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);
                     .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAutoMapper(typeof(MappingProfile), typeof(PhonebookMappingProfile));
            services.AddMediatR(typeof(AddUserCommandEventHandler).Assembly, typeof(AddPhoneBookCommandEventHandler).Assembly);

            services.AddDbContext<StoreDBContext>(e => { e.UseSqlServer(Configuration.GetConnectionString("Default")); });
            services.AddDbContext<PhoneBookDBContext>(e => { e.UseSqlServer(Configuration.GetConnectionString("PhonebookConnectionString")); });
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddRepositoryServices();
            services.AddSwagger();


            //checking for the presence of the scope in the access token
            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiScope", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", Configuration["AppSettings:Scope"]);
                });
            });
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddJwtBearer(IdentityServerAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.Authority = Configuration["AppSettings:IDP"];                    

                    options.TokenValidationParameters = new TokenValidationParameters
                    {                        
                        ValidateAudience = false
                    };
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger(x => { x.SerializeAsV2 = true; });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(Configuration["AppSettings:VirtualDirectory"] +
                                  "/swagger/v1/swagger.json", "Insurance Collections Payments-Collections API V1");
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireAuthorization("ApiScope"); 
            });
        }
    }
}
