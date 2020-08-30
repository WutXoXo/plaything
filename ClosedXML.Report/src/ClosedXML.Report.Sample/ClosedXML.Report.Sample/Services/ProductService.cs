using ClosedXML.Report.Sample.Entities.Sqlite;
using ClosedXML.Report.Sample.Repositories.Abstractions;
using ClosedXML.Report.Sample.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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
            return await _productRepository.GetProductAsync();
        }

        public async Task<ProductEntity> UpdateProductAsync(ProductEntity product)
        {
            throw new NotImplementedException();
        }
    }
}
