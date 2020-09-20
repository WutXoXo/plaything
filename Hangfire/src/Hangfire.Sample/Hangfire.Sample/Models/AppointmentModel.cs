using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Models
{
    /// <summary>
    /// แจ้งเตือนนัดหมาย
    /// </summary>
    public class AppointmentModel
    {
        /// <summary>
        /// ประเภทงาน
        /// 1 = Fire and forget jobs คือ run function ทันทีและไม่กลับมาทำอีก
        /// 2 = Delayed jobs คือ run function ตามเวลาที่กำหนดและไม่กลับมาทำอีก
        /// </summary>
        [Required]
        [JsonRequired]
        [Range(1, Int32.MaxValue)]
        [JsonProperty("jobs_type")]
        public int JobsType { get; set; }

        /// <summary>
        /// รหัสนัดหมาย
        /// </summary>
        [Required]
        [JsonRequired]
        [Range(1, Int32.MaxValue)]
        [JsonProperty("appointment_id")]
        public long AppointmentId { get; set; }

        /// <summary>
        /// รหัสนัดหมาย
        /// </summary>
        [Required]
        [JsonRequired]
        [JsonProperty("appointment_key")]
        public string AppointmentKey { get; set; }

        /// <summary>
        /// เวลาทำงาน
        /// </summary>
        [JsonProperty("trigger_date")]
        public DateTime? TriggerDate { get; set; }

        /// <summary>
        /// รหัสงาน
        /// </summary>
        [JsonProperty("jobs_id")]
        public string JobsId { get; set; }
    }
}
