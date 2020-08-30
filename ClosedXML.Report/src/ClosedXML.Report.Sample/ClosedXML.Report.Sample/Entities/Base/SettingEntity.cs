using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedXML.Report.Sample.Entities.Base
{
    /// <summary>
    /// ข้อมูลสำหรับการตั้งค่า
    /// </summary>
    public class SettingEntity : ConstEntity
    {
        /// <summary>
        /// อัปเดตเวลา
        /// </summary>
        [Column("updatedAt")]
        [Required]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// อัปเดตโดย
        /// </summary>
        [Column("updatedBy")]
        [Required]
        public long UpdatedBy { get; set; }

        /// <summary>
        /// แก้ไข
        /// </summary>
        /// <param name="user_id">ผู้แก้ไข</param>
        public virtual void Edit(long userId)
        {
            this.UpdatedBy = userId;
            this.UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// การกระทำ
        /// </summary>
        /// <param name="createdBy">สร้างโดย</param>
        /// <param name="updatedBy">อัปเดตโดย</param>
        public virtual void Action(long createdBy,long updatedBy)
        {
            base.Create(createdBy);
            this.Edit(updatedBy);
        }
    }
}
