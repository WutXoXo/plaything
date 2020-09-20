using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Models
{
    /// <summary>
    /// พื้นฐานข้อมูลงาน
    /// </summary>
    public class JobsBase
    {
        /// <summary>
        /// ประเภทงาน
        /// 1 = Fire and forget jobs คือ run function ทันทีและไม่กลับมาทำอีก
        /// 2 = Delayed jobs คือ run function ตามเวลาที่กำหนดและไม่กลับมาทำอีก
        /// 3 = Recurring jobs คือ run function ตามเวลาที่กำหนดและกลับมาทำอีก
        /// </summary>
        [Required]
        [JsonRequired]
        [Range(1,Int32.MaxValue)]
        [JsonProperty("jobs_type")]
        public int JobsType { get; set; }

        /// <summary>
        /// รหัสฟังก์ชัน
        /// </summary>
        [Required]
        [JsonRequired]
        [Range(1, Int32.MaxValue)]
        [JsonProperty("function_id")]
        public int FunctionId { get; set; }

        /// <summary>
        /// เวลาทำงาน
        /// </summary>
        [Required]
        [JsonRequired]
        [JsonProperty("trigger_date")]        
        public DateTime TriggerDate { get; set; }
    }
}
