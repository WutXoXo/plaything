using ClosedXML.Report.Sample.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Entities.Sqlite
{
    /// <summary>
    /// สินค้าและบริการ
    /// </summary>
    [Table("m_product")]
    public class ProductEntity : SettingEntity
    {
        /// <summary>
        /// รหัสสินค้าและบริการ
        /// </summary>
        [Key]
        [Required]
        [Column(name: "id")]
        public long Id { get; set; }

        /// <summary>
        /// ชื่อสินค้าและบริการ
        /// </summary>
        [Required]
        [Column(name: "name")]
        public string Name { get; set; }

        /// <summary>
        /// โค้ดสินค้าและบริการ
        /// </summary>
        [Column(name: "code")]
        public string Code { get; set; }

        /// <summary>
        /// บาร์โค้ดสินค้าและบริการ
        /// </summary>
        [Column(name: "barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// ราคาสินค้าและบริการ
        /// </summary>
        [Required]
        [Column(name: "price")]
        public double Price { get; set; }

        /// <summary>
        /// รายละเอียดสินค้าและบริการ
        /// </summary>
        [Column(name: "description")]
        public string Description { get; set; }

        /// <summary>
        /// จำนวนสินค้าและบริการ
        /// </summary>
        [Required]
        [Column(name: "quantity")]
        public double Quantity { get; set; }
    }
}
