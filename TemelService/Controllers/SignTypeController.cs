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

    public class SignTypeController : Controller
    {
        private readonly ISignTypeManager _SignTypeManager;
        public SignTypeController(ISignTypeManager SignTypeManager)
        {
            _SignTypeManager =SignTypeManager;
        }

        [HttpGet("SignTypeList")]
        public IActionResult GetSignTypeList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_SignTypeManager.getList().Data, jso));

        }

        [HttpPost("AddSignType")]
        public IActionResult AddSignType([FromBody] SignType SignType)
        {
            var result = _SignTypeManager.Add(SignType);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
               
        }

        [HttpPost("EditSignType/{id}")]
        public IActionResult EditSignType(int id, [FromBody] string explanation)
        {
            var result = _SignTypeManager.UpdateSignType(id,explanation);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

            [HttpPost("DeleteSignType")]
        public IActionResult DeleteSignType(int SignTypeId)
        {
            var result = _SignTypeManager.Delete(SignTypeId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
