using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.Common;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Core.Repository.Read;
using Rajanell.TechStack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.Repository.Read
{
    public class ProductCategoryQueryRepository : IProductCategoryQueryRepository
    {
        private readonly StoreDBContext _context;
        private readonly ILogger<ProductCategoryQueryRepository> _logger;

        public ProductCategoryQueryRepository(StoreDBContext context, ILogger<ProductCategoryQueryRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<ProductCategory>> Find(Expression<Func<ProductCategory, bool>> query)
        {
            return await Task.Run(() => _context.ProductCategories.Where(query).ToListAsync());
        }

        public async Task<IEnumerable<ProductCategory>> GetAll()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        public async Task<ProductCategory> GetByID(Guid id)
        {
            return await _context.ProductCategories.FindAsync(id);
        }
    }
}
