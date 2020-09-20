using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Utilities
{
    /// <summary>
    /// Jobs Type Utility
    /// </summary>
    public class JobsTypeUtility
    {
        /// <summary>
        /// Fire and forget jobs คือ run function ทันทีและไม่กลับมาทำอีก
        /// </summary>
        public const int FIRE_AND_FORGET = 1;

        /// <summary>
        /// Delayed jobs คือ run function ตามเวลาที่กำหนดและไม่กลับมาทำอีก
        /// </summary>
        public const int DELAYED = 2;

        /// <summary>
        /// Recurring jobs คือ run function ตามเวลาที่กำหนดและกลับมาทำอีก
        /// </summary>
        public const int RECURRING = 3;
    }
}
