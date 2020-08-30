using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Entities.Base
{
    /// <summary>
    /// ข้อมูลพื้นฐานค่าคงที
    /// </summary>
    public class ConstEntity
    {
        /// <summary>
        /// เปิดใช้งานอยู่
        /// </summary>
        [Column("isActive")]
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// สร้างเมื่อ
        /// </summary>
        [Column("createdAt")]
        [Required]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// สร้างโดย
        /// </summary>
        [Column("createdBy")]
        [Required]
        public long CreatedBy { get; set; }

        /// <summary>
        /// สร้าง
        /// </summary>
        /// <param name="user_id">ผุ้สร้าง</param>
        public virtual void Create(long userId)
        {
            this.CreatedBy = userId;
            this.CreatedAt = DateTime.Now;
            this.IsActive = true;
        }
    }
}
