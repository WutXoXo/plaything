using ClosedXML.Report.Sample.Contexts.Sqlite;
using ClosedXML.Report.Sample.Entities.Sqlite;
using ClosedXML.Report.Sample.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<ProductEntity> AddProductAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProductAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductEntity>> GetProductAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<ProductEntity> GetProductAsync(long id)
        {
            return await _context.Product.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<ProductEntity> UpdateProductAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }
    }
}
