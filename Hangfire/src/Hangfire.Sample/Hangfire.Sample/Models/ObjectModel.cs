using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Models
{
    /// <summary>
    /// ข้อมูลตอบกลับ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjectModel<T> : OutputBase
        where T : class
    {
        /// <summary>
        /// ข้อมูล
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
