using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Core.Repository.Write;
using Rajanell.TechStack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.Repository.Write
{
    public class ProductCategoryCommandRepository : IProductCategoryCommandRepository
    {
        private readonly StoreDBContext _context;
        private readonly ILogger<ProductCategoryCommandRepository> _logger;

        public ProductCategoryCommandRepository(StoreDBContext context, ILogger<ProductCategoryCommandRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(ProductCategory item)
        {
            _context.Add(item);
        }

        public void Add(IEnumerable<ProductCategory> items)
        {
            _context.AddRange(items);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(ProductCategory item)
        {
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Update(IEnumerable<ProductCategory> items)
        {
            foreach (var item in items)
            {
                _context.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }
        }
    }
}
