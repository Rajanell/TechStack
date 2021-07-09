using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using Rajanell.TechStack.Phonebook.Web.HttpHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.Client.Web
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
            services.AddControllersWithViews();
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddTransient<BearerTokenHandler>();
            // create an HttpClient used for accessing the middleware
            services.AddHttpClient("APIClient", client =>
            {
                client.BaseAddress = new Uri(Configuration["AppSettings:APIBaseUrl"]);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            }).AddHttpMessageHandler<BearerTokenHandler>();

           // services.AddAuthentication(options =>
           // {
           //     options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
           //     options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
           // })
           //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
           //{
           //    options.AccessDeniedPath = "/Authorization/AccessDenied";
           //}).AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
           //{
           //    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
           //    options.Authority = "https://localhost:5001/";
           //    options.ClientId = "PhonebookClient";
           //    options.ClientSecret = "secret2";
           //    options.ResponseType = "code";
           //    options.Scope.Add("openid");
           //    options.SaveTokens = true;
           //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
