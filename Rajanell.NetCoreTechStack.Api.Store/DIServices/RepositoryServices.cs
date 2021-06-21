using Microsoft.Extensions.DependencyInjection;
using Rajanell.TechStack.Core.Repository;
using Rajanell.TechStack.Core.Repository.Read;
using Rajanell.TechStack.Core.Repository.Write;
using Rajanell.TechStack.Services.Repository;
using Rajanell.TechStack.Services.Repository.Read;
using Rajanell.TechStack.Services.Repository.Write;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store.DIServices
{
    public static class RepositoryServices
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            //Command
            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            services.AddScoped<IProductCategoryCommandRepository, ProductCategoryCommandRepository>();
            //Query
            services.AddScoped<IUserQueryRepository, UserQueryRepository>();
            services.AddScoped<IProductCategoryQueryRepository, ProductCategoryQueryRepository>();
            //Generic repository
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
