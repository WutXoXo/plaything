using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire.Sample.Models;
using Hangfire.Sample.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hangfire.Sample.Controllers
{
    /// <summary>
    /// งาน
    /// </summary>
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobsService _jobsService;

        /// <summary>
        /// งาน
        /// </summary>
        /// <param name="jobsService"></param>
        public JobsController(IJobsService jobsService)
        {
            _jobsService = jobsService;
        }


        /// <summary>
        /// เพิ่มแจ้งเตือนนัดหมาย
        /// </summary>
        /// <param name="appointmentModel">ข้อมูลงาน</param>
        [HttpPost("appointment")]
        public async Task<ActionResult<ObjectModel<AppointmentModel>>> PostAppointment([FromBody] AppointmentModel appointmentModel)
        {
            ObjectModel<AppointmentModel> result = new ObjectModel<AppointmentModel>();
            result.Data = await _jobsService.AddAppointmentAsync(appointmentModel);
            return Ok(result);
        }

        /// <summary>
        /// เพิ่มงาน
        /// </summary>
        /// <param name="jobsBase">ข้อมูลงาน</param>
        [HttpPost]
        public async Task<ActionResult<ObjectModel<JobsModel>>> Post([FromBody] JobsBase jobsBase)
        {
            ObjectModel<JobsModel> result = new ObjectModel<JobsModel>();
            result.Data = await _jobsService.AddJobsAsync(jobsBase);
            return Ok(result);
        }

        /// <summary>
        /// ยกเลิกงาน
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task<ActionResult<OutputBase>> Delete(string id)
        {
            OutputBase result = new OutputBase();
            bool isDeleted = await _jobsService.DeleteJobsAsync(id);
            if (isDeleted)
            {
                return Ok(result);
            }

            result.ErrorId = 11;
            result.ErrorCode = "A1";
            return BadRequest(result);
        }
    }
}
