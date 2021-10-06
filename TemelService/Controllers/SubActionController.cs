using Bussines.Abstract;
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
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpGet("SubActionListFull")]
        public IActionResult SubActionListFull()
        {
            var result = _SubActionManager.SubActionListFull();
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }


        [HttpPost("AddSubAction")]
        public IActionResult AddSubAction([FromBody] DAL.Model.SubAction SubAction)
        {
            var result = _SubActionManager.AddSubAction(SubAction);
            if (result.IsValid)
            {
                return Ok();
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
