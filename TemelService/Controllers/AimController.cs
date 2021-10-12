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

    public class AimController : Controller
    {
        private readonly IAimManager _aimManager;
        public AimController(IAimManager aimManager)
        {
            _aimManager = aimManager;
        }

        [HttpGet("AimList")]
        public IActionResult GetAimList(int periotId)
        {
            var result = _aimManager.AimList(periotId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpPost("AddAim")]
        public IActionResult AddAim([FromBody] Aim aim)
        {
            var result = _aimManager.AddAim(aim);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
               
        }

        [HttpPost("EditAim/{id}")]
        public IActionResult EditAim(int id, [FromBody] string explanation)
        {
            var result = _aimManager.EditAim(id,explanation);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

            [HttpPost("DeleteAim")]
        public IActionResult GetProjectList(int aimId)
        {
            var result = _aimManager.DeleteAim(aimId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
