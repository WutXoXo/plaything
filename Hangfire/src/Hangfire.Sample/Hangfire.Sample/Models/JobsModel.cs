using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Models
{
    /// <summary>
    /// ข้อมูลงาน
    /// </summary>
    public class JobsModel : JobsBase
    {
        /// <summary>
        /// รหัสงาน
        /// </summary>
        [JsonProperty("jobs_id")]
        public string JobsId { get; set; }
    }
}
