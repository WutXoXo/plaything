using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Models
{
    /// <summary>
    /// รายการตอบกลับ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListModel<T> : OutputBase
        where T : class
    {
        /// <summary>
        /// ข้อมูล
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }
    }
}
