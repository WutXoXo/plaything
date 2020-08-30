using ClosedXML.Report.Sample.Entities.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Services.Abstractions
{
    public interface IProductService
    {
        Task<List<ProductEntity>> GetProductAsync();

        Task<ProductEntity> AddProductAsync(ProductEntity product);

        Task<ProductEntity> UpdateProductAsync(ProductEntity product);

        Task DeleteProductAsync(ProductEntity product);
    }
}
