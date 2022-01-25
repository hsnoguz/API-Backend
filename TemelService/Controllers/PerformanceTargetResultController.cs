using Bussines.Abstract;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class PerformanceTargetResultController : Controller
    {
        public IPerformanceTargetResultManager _performanceTargetResultManager;
        public PerformanceTargetResultController(IPerformanceTargetResultManager performanceTargetResultManager)
        {
            _performanceTargetResultManager = performanceTargetResultManager;
        }

        [HttpPost("InsertPerformanceTargetResult")]
        public IActionResult InsertPerformanceTargetResult([FromBody] Performance_Target_Result performanceTragetResult)
        {
            var result = _performanceTargetResultManager.InsertPerformanceTargetResult(performanceTragetResult);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("EditPerformanceTargetResult")]
        public IActionResult EditPerformanceTargetResult([FromBody] Performance_Target_Result performanceTragetResult)
        {
            var result = _performanceTargetResultManager.EditPerformanceTargetResult(performanceTragetResult);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpPost("EditPerformanceTargetValue")]
        public IActionResult EditPerformanceTargetValue([FromBody] PerformancePeriotMatchTargetValue performanceTragetValue)
        {
            var result = _performanceTargetResultManager.EditPerformanceTargeValue(performanceTragetValue);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpPost("EditOrganizationId/{performanceMatchId}/{organizationId}")]
        public IActionResult EditOrganizationId(int performanceMatchId, int organizationId)
        {
            var result = _performanceTargetResultManager.EditOrganizationId(performanceMatchId,organizationId);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
