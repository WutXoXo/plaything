using Hangfire.Sample.Models;
using Hangfire.Sample.Services.Abstractions;
using Hangfire.Sample.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangfire.Sample.Services
{
    /// <summary>
    /// Jobs Service
    /// </summary>
    public class JobsService : IJobsService
    {
        private readonly IBackgroundJobClient _backgroundJobClient;

        /// <summary>
        /// Jobs Service
        /// </summary>
        /// <param name="backgroundJobClient"></param>
        public JobsService(IBackgroundJobClient backgroundJobClient)
        {
            _backgroundJobClient = backgroundJobClient;
        }

        /// <summary>
        /// แจ้งเตือนนัดหมาย
        /// </summary>
        /// <param name="appointmentModel">ข้อมูลงาน</param>
        /// <returns></returns>
        public async Task<AppointmentModel> AddAppointmentAsync(AppointmentModel appointmentModel)
        {            
            string jobsId = "";
            switch (appointmentModel.JobsType)
            {
                case JobsTypeUtility.FIRE_AND_FORGET:
                    jobsId  = _backgroundJobClient.Enqueue(
                           () => Console.WriteLine($"id {appointmentModel.AppointmentId} key {appointmentModel.AppointmentKey}")
                       );
                    break;
                case JobsTypeUtility.DELAYED:
                    DateTime now = DateTime.UtcNow;
                    if (appointmentModel.TriggerDate.Value.Kind != DateTimeKind.Utc) appointmentModel.TriggerDate = appointmentModel.TriggerDate.Value.ToUniversalTime();
                    TimeSpan difference = appointmentModel.TriggerDate.Value.Subtract(now);
                    jobsId = _backgroundJobClient.Schedule(
                           () => Console.WriteLine($"id {appointmentModel.AppointmentId} key {appointmentModel.AppointmentKey}"),
                           difference
                       );
                    break;
            }
            appointmentModel.JobsId = jobsId;
            return appointmentModel;

        }

        /// <summary>
        /// เพิ่มงาน
        /// </summary>
        /// <param name="jobsBase">ข้อมูลงาน</param>
        /// <returns></returns>
        public async Task<JobsModel> AddJobsAsync(JobsBase jobsBase)
        {
            DateTime now = DateTime.UtcNow;
            if (jobsBase.TriggerDate.Kind != DateTimeKind.Utc) jobsBase.TriggerDate = jobsBase.TriggerDate.ToUniversalTime();
            TimeSpan difference = now.Subtract(jobsBase.TriggerDate);

            string jobsId = _backgroundJobClient.Schedule(
                    ()=> Console.WriteLine(difference.ToString()),
                    difference
                );
            return new JobsModel()
            {
                JobsId = jobsId,
                JobsType = jobsBase.JobsType,
                FunctionId = jobsBase.FunctionId,
                TriggerDate = jobsBase.TriggerDate
            };
        }

        /// <summary>
        /// ยกเลิกงาน
        /// </summary>
        /// <param name="jobsId">รหัสงาน</param>
        /// <returns></returns>
        public async Task<bool> DeleteJobsAsync(string jobsId)
        {
            _backgroundJobClient.Delete(jobsId);
            return true;
        }
    }
}
