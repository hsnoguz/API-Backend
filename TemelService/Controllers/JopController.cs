using Bussines.Abstract;
using Bussines.Service.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    
    [Route("jop/[controller]")]

    public class JopController : Controller
    {
        private IJopService _JopService;

        public JopController(IJopService JopService)
        {
            _JopService = JopService;
        }


        [HttpGet("jopList")]
        public IActionResult JopList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_JopService.getList().Data, jso));
      
        }

        [HttpPost("jopAdd")]
        public IActionResult JopAdd(Jop Jop)
        {
            IResult result = _JopService.Add(Jop);

            if (result.IsValid)
                return Ok();
            else
            {
                return BadRequest(result.Message);
            }
      
        }

        [HttpPost("jopDelete")]
        public IActionResult JopDelete(int Id)
        {
            IResult result = _JopService.Delete(Id);

            if (result.IsValid)
                return Ok();
            else
            {
                return BadRequest(result.Message);
            }

      
        }
    }
}
