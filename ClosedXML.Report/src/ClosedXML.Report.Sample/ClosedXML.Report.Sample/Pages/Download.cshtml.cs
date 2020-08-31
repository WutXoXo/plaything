using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Report.Sample.Entities.Sqlite;
using ClosedXML.Report.Sample.Models;
using ClosedXML.Report.Sample.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClosedXML.Report.Sample.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IProductService _productService;
        public DownloadModel(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> OnGet(long id)
        {
            byte[] excelBytes = null;
            ProductEntity product = await _productService.GetProductAsync(id);
            if (product != null)
            {
                ProductModel productModel = new ProductModel()
                {
                    Id = product.Id,
                    Code = product.Code,
                    Barcode = product.Barcode,
                    Description = product.Description,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity
                };
                var template = new XLTemplate(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "ProductTemplate.xlsx"));
                template.AddVariable("code", product.Code);
                template.AddVariable("name", product.Barcode);
                template.AddVariable("price", product.Price);
                template.AddVariable("quantity", product.Quantity);
                template.Generate();                

                using (var stream = new MemoryStream())
                {
                    template.Workbook.SaveAs(stream);
                    excelBytes = stream.ToArray();
                }                
            }
            return File(excelBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Product.xlsx");
        }
    }
}
