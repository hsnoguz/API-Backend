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

    public class SubActionController : Controller
    {
        private readonly ISubActionManager _SubActionManager;
        public SubActionController(ISubActionManager SubActionManager)
        {
            _SubActionManager = SubActionManager;
        }

        [HttpGet("SubActionList/{actionId}")]
        public IActionResult GetSubActionList(int actionId)
        {
            var result = _SubActionManager.SubActionList(actionId);


            return Ok(result);
        }

   /*     [HttpGet("ListFullPlan")]
        public IActionResult ListFullPlan()
        {

            var result = _SubActionManager.ListFullPlan(Convert.ToInt32(User.ClaimPeriotId().ToString()));

            return Ok(result);
        }*/

      /*  [HttpGet("SubActionListFull")]
        public IActionResult SubActionListFull()
        {

            var result = _SubActionManager.SubActionListFull(Convert.ToInt32(User.ClaimPeriotId().ToString()));

            return Ok(result);
        }
      */

        [HttpGet("SubActionListFull")]
        public IActionResult SubActionActionTargetAimList()
        {

            var result = _SubActionManager.SubActionActionTargetAimList(Convert.ToInt32(User.ClaimPeriotId().ToString()));

            return Ok(result);
        }


        [HttpPost("EditAction/id/newActionId")]
        public IActionResult EditAction(int id, int newActionId) {
            var result = _SubActionManager.EditAction(id, newActionId);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }


        [HttpGet("GetSubAction_OrganizationId/{subActionId}")]
        public IActionResult GetSubAction_OrganizationId(int subActionId)
        {
            var result = _SubActionManager.GetOrganizationId(subActionId).Data;

            return Ok(result);
        }

        [HttpPost("EditSubAction")]
        public IActionResult EditSubAction([FromBody] SubAction subAction)
        {
            var result = _SubActionManager.EditSubAction(subAction);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("AddSubAction")]
        public IActionResult AddSubAction([FromBody] DAL.Model.SubAction SubAction)
        {
            var result = _SubActionManager.AddSubAction(SubAction);
            if (result.IsValid)
            {
                return Ok(SubAction.Id);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("DeleteSubAction/{SubActionId}")]
        public IActionResult GetProjectList(int SubActionId)
        {
            var result = _SubActionManager.DeleteSubAction(SubActionId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
