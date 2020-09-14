using System;
using System.Collections.Generic;


namespace ClosedXML.Report.Sample.Models
{
    public class ProductModel
    {
        /// <summary>
        /// รหัสสินค้าและบริการ
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// ชื่อสินค้าและบริการ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// โค้ดสินค้าและบริการ
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// บาร์โค้ดสินค้าและบริการ
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// ราคาสินค้าและบริการ
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// รายละเอียดสินค้าและบริการ
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// จำนวนสินค้าและบริการ
        /// </summary>
        public double Quantity { get; set; }
    }

    public class ProductsModel
    {
        /// <summary>
        /// สินค้าและบริการ
        public IEnumerable<ProductModel> Products { get; set; }
        
    }
}
