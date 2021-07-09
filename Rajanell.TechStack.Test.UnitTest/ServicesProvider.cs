using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rajanell.TechStack.Core.Repository.Read;
using Rajanell.TechStack.Core.Service;
using Rajanell.TechStack.Infrastructure.Data;
using Rajanell.TechStack.Services;
using Rajanell.TechStack.Services.Repository.Read;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Rajanell.TechStack.Test.UnitTest
{
    public static class ServicesProvider
    {
        public static IServiceProvider GetServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration config = builder.Build();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserQueryRepository, UserQueryRepository>();
            services.AddDbContext<StoreDBContext>(e => { e.UseSqlServer(config.GetConnectionString("Default")); });

            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);

            var container = containerBuilder.Build();
            var serviceProvider = new AutofacServiceProvider(container);

            return serviceProvider;
        }
    }
}
