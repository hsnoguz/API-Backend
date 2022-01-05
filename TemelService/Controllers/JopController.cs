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
        
            return Ok(_JopService.getList().Data);
      
        }

        [HttpPost("jopAdd")]
        public IActionResult JopAdd([FromBody] Jop Jop)
        {
            IResult result = _JopService.Add(Jop);

            if (result.IsValid)
                return Ok();
            else
            {
                return BadRequest(result.Message);
            }
      
        }

        [HttpPost("jopDelete/{id}")]
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
