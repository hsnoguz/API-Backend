using Bussines.Abstract;
using Bussines.Service.Abstract;
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

    public class SignPeriotController : Controller
    {
        private readonly ISignPeriot _signPeriotManager;
        public SignPeriotController(ISignPeriot signPeriotManager)
        {
            _signPeriotManager =signPeriotManager;
        }

        [HttpGet("SignPeriotList")]
        public IActionResult GetSignPeriotList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_signPeriotManager.getList().Data, jso));

        }

        [HttpPost("AddSignPeriot")]
        public IActionResult AddSignPeriot([FromBody] PerformancePeriot signPeriot)
        {
            var result = _signPeriotManager.AddSignPeriot(signPeriot);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
               
        }

        [HttpPost("EditSignPeriot/{id}")]
        public IActionResult EditSignPeriot(int id, [FromBody] Int16 explanation)
        {
            var result = _signPeriotManager.UpdateSignPeriot(id,explanation);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

            [HttpPost("DeleteSignPeriot")]
        public IActionResult DeleteSignPeriot(int signPeriotId)
        {
            var result = _signPeriotManager.Delete(signPeriotId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
