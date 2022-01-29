using Bussines.Abstract;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class ManualPageController : Controller
    {
        IManualPageManager _manualPageManager;
        public ManualPageController(IManualPageManager manualPageManager)
        {
            _manualPageManager = manualPageManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getManualPage/{Id}")]
        public IActionResult getManualPage(int Id)
        {
            return Ok(_manualPageManager.GetManualPage(Id).Data);
        }

        [HttpPost("insertManualPage")]
        public IActionResult insertManualPage([FromBody] ManualPage manualPage)
        {
            var result = _manualPageManager.InsertManualPage(manualPage);
            if (result.IsValid)
                return Ok(result.Data);
            else
                return BadRequest(result.Message);
        }

        [HttpPost("editManualPage")]
        public IActionResult editManualPage([FromBody] ManualPage manualPage)
        {
            var result = _manualPageManager.EditManualPage(manualPage);
            if (result.IsValid)
                return Ok();
            else
                return BadRequest(result.Message);
        }

        [HttpPost("deleteManualPage/{Id}")]
        public IActionResult deleteManualPage(int Id)
        {
            var result = _manualPageManager.DeleteManualPage(Id);
            if (result.IsValid)
                return Ok();
            else
                return BadRequest(result.Message);
        }
    }
}
