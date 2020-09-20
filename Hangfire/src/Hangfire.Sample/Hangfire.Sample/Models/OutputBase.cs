using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Models
{
    /// <summary>
    /// พื้นฐานข้อมูลตอบกลับ
    /// </summary>
    public class OutputBase
    {
        /// <summary>
        /// รหัสผิดพลาด
        /// </summary>
        [JsonProperty("error_id")]
        public int ErrorId { get; set; } = 1;

        /// <summary>
        /// โค้ดผิดพลาด
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; } = "1";

        /// <summary>
        /// หัวผิดพลาด
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = "";

        /// <summary>
        /// ข้อความผิดพลาด
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// รายละเอียดผิดพลาด
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; } = "";
    }
}
