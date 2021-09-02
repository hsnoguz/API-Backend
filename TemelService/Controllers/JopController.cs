using Bussines.Abstract;
using Bussines.Service.Abstract;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    
    [Route("jop/[controller]")]
    [Authorize()]
    public class JopController : Controller
    {
        private IJopService _JopService;

        public JopController(IJopService JopService)
        {
            _JopService = JopService;
        }


        [HttpGet("jopList")]
        public IResultData<List<Jop>>  JopList()
        {
          return  _JopService.getList();
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

        [HttpDelete("jopDelete")]
        public IActionResult JopDelete(Jop Jop)
        {
            IResult result = _JopService.Delete(Jop);

            if (result.IsValid)
                return Ok();
            else
            {
                return BadRequest(result.Message);
            }

      
        }
    }
}
