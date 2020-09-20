using Hangfire.Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Services.Abstractions
{
    /// <summary>
    /// interface jobs service
    /// </summary>
    public interface IJobsService
    {
        /// <summary>
        /// แจ้งเตือนนัดหมาย
        /// </summary>
        /// <param name="appointmentModel">ข้อมูลงาน</param>
        /// <returns></returns>
        Task<AppointmentModel> AddAppointmentAsync(AppointmentModel appointmentModel);

        /// <summary>
        /// เพิ่มงาน
        /// </summary>
        /// <param name="jobsBase">ข้อมูลงาน</param>
        /// <returns></returns>
        Task<JobsModel> AddJobsAsync(JobsBase jobsBase);
        
        /// <summary>
        /// ยกเลิกงาน
        /// </summary>
        /// <param name="jobsId">รหัสงาน</param>
        /// <returns></returns>
        Task<bool> DeleteJobsAsync(string jobsId);
    }
}
