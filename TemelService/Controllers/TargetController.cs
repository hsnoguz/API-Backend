using Bussines.Abstract;
using Core.Extensions;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemelService.Controllers
{

    [Route("[controller]")]

    public class TargetController : Controller
    {
        private readonly ITargetManager _TargetManager;
        public TargetController(ITargetManager TargetManager)
        {
            _TargetManager = TargetManager;
        }

        [HttpGet("TargetList/{aimId}")]
        public IActionResult GetTargetList(int aimId)
        {
            var result = _TargetManager.TargetList(aimId);

            return Ok(result);
        }

    /*    [HttpGet("TargetListFull")]
        public IActionResult TargetListFull()
        {
            var result = _TargetManager.TargetListFull(Convert.ToInt32(User.ClaimPeriotId().ToString()));
            return Ok(result);
        }*/

        [HttpGet("TargetListFull")]
        public IActionResult TargetAimnList()
        {
            var result = _TargetManager.TargetAimList(Convert.ToInt32(User.ClaimPeriotId().ToString()));
            return Ok(result);
        }

        [HttpPost("EditAim/{id}/{aimId}")]
        public IActionResult EditAim(int id, int aimId) {
            var result = _TargetManager.EditAim(id,aimId);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("EditTarget/{id}/{aimId}")]
        public IActionResult EditTarget(int id, int aimId, [FromBody] string explanation) {
            var result = _TargetManager.EditTarget(id,aimId,explanation);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }



        [HttpPost("AddTarget")]
        public IActionResult AddTarget([FromBody] Target Target)
        {
            var result = _TargetManager.AddTarget(Target);
            if (result.IsValid)
            {
                return Ok(Target.Id);
            }
            else
            {
                return BadRequest(result.Message);
            }
               
        }

        [HttpPost("DeleteTarget/{TargetId}")]
        public IActionResult GetProjectList(int TargetId)
        {
            var result = _TargetManager.DeleteTarget(TargetId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
