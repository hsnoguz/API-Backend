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
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpGet("TargetListFull")]
        public IActionResult TargetListFull(int aimId)
        {
            var result = _TargetManager.TargetListFull();
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpPost("AddTarget")]
        public IActionResult AddTarget([FromBody] Target Target)
        {
            var result = _TargetManager.AddTarget(Target);
            if (result.IsValid)
            {
                return Ok();
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
