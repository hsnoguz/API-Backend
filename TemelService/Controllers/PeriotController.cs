using Bussines.Abstract;
using Bussines.Concrete;
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

    public class PeriotController : Controller
    {
        IPeriotManager _periotManager;
        public PeriotController(IPeriotManager periotManager)
        {
            _periotManager = periotManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("createPeriot")]
        public ActionResult CreatePeriot([FromBody] Periot periot)
        {
        
            IResult result=_periotManager.createPeriot(periot.Name, periot.StartYear, periot.StopYear);
            if (result.IsValid)
            {
               return Ok();
            }
            else
            {
              return  BadRequest(result.Message);
            }

        }


        [HttpGet("listPeriot")]
        public ActionResult ListPeriot()
        {

            IResultData<List<Periot>> result = _periotManager.listPeriot();
            if (result.IsValid)
            {
   
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
    }
}
