using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Report.Sample.Entities.Sqlite;
using ClosedXML.Report.Sample.Models;
using ClosedXML.Report.Sample.Services.Abstractions;
using FastMember;
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

        public async Task<IActionResult> OnGet(long? id = null)
        {
            byte[] excelBytes = null;
            if (id != null)
            {
                ProductEntity product = await _productService.GetProductAsync(id.Value);
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
            else
            {
                List<ProductEntity> products = await _productService.GetProductAsync();
                if (products != null && products.Count > 0)
                {
                    ProductsModel productsModel = new ProductsModel();
                    productsModel.Products = products.Select(s => new ProductModel()
                    {
                        Id = s.Id,
                        Code = s.Code,
                        Barcode = s.Barcode,
                        Description = s.Description,
                        Name = s.Name,
                        Price = s.Price,
                        Quantity = s.Quantity
                    }).ToList();

                    DataTable table = new DataTable();
                    using (var reader = ObjectReader.Create(productsModel.Products))
                    {
                        table.Load(reader);
                    }

                    var template = new XLTemplate(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "ProductListTemplate.xlsx"));
                    template.AddVariable(productsModel);
                    template.AddVariable("items", table);
                    //template.AddVariable("Id", "Id");
                    //template.AddVariable("Code", "Code");
                    //template.AddVariable("Barcode", "Barcode");
                    //template.AddVariable("Description", "Description");
                    //template.AddVariable("Name", "Name");
                    //template.AddVariable("Price", "Price");
                    //template.AddVariable("Quantity", "Quantity");
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
}
