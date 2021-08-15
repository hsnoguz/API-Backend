using Bussines.Concrete;
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
    [Authorize()]
    public class PeriotController : Controller
    {
        PeriotManager _periotManager;
        public PeriotController(PeriotManager periotManager)
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
    }
}
