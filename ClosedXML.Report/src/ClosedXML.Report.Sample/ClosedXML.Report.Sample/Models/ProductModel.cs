using LinqToDB.Mapping;
using System;
using System.Collections.Generic;


namespace ClosedXML.Report.Sample.Models
{
    public class ProductModel
    {
        /// <summary>
        /// รหัสสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Id", OtherKey = "Id")]
        public long Id { get; set; }

        /// <summary>
        /// ชื่อสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Name", OtherKey = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// โค้ดสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Code", OtherKey = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// บาร์โค้ดสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Barcode", OtherKey = "Barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// ราคาสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Price", OtherKey = "Price")]
        public double Price { get; set; }

        /// <summary>
        /// รายละเอียดสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Description", OtherKey = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// จำนวนสินค้าและบริการ
        /// </summary>
        [Association(ThisKey = "Quantity", OtherKey = "Quantity")]
        public double Quantity { get; set; }
    }

    public class ProductsModel
    {
        /// <summary>
        /// สินค้าและบริการ
        public List<ProductModel> Item { get; set; }
        
    }
}
