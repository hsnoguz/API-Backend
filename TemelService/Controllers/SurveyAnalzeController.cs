using Bussines.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    [Route("[controller]")]
    public class SurveyAnalzeController : Controller
    {

        private readonly ISurveyAnalzeManager _surveyAnalze;
        public SurveyAnalzeController(ISurveyAnalzeManager surveyAnalze)
        {
            _surveyAnalze = surveyAnalze;
        }


        [HttpGet("GetSwot/{projectId}")]
            public async Task<ActionResult> GetSwot(int projectId)
            {
                var result = await _surveyAnalze.getSwot(projectId);
                return Ok(result);
            }
        }
}
