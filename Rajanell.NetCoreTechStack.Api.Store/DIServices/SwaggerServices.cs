using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;

namespace Rajanell.TechStack.API.Store.DIServices
{
    public static class SwaggerServices
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Rajanell TechStack : Store API",
                    Version = "v1",
                    Description = "Rajanell Tech Stack Middleware",
                    Contact = new OpenApiContact { Name = "Rajanell", Email = "lucks.rajane@gmail.com", Url = new Uri("http://www.google.com") }
                });
            });
        }
    }
}
