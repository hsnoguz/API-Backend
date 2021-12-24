using Bussines.Abstract;
using Bussines.Service.Abstract;
using Core.Extensions;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class LeftMenuController : Controller
    {
        private ILeftMenuManager _leftMenu;
        private IOperationService _operationService;
        public LeftMenuController(ILeftMenuManager leftMenu, IOperationService operationService)
        {

            _leftMenu = leftMenu;
            _operationService = operationService;
            // _userManager = userManager;

        }

        [HttpPost("AddLeftMenu")]
        public IActionResult AddLeftMenu([FromBody] LeftMenu leftMenu)
        {
            var result = _leftMenu.AddLeftMenu(leftMenu);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("DeleteLeftMenu/{Id}")]
        public IActionResult DeleteLeftMenu(int Id)
        {
            var result = _leftMenu.DeleteLeftMenu(Id);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
               
            }
        }


        [HttpGet("GetLeftMenu")]
        public IActionResult GetLeftMenu()
        {

            /*       var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                   var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                   var userId2 = claim.Value;*/
            //    var userId = user.ClaimNameIdentifier()[0];
            //   var roleId = _operationService.RoleId(user.ClaimRoles()[0]);
            //     return View(_leftMenu.GetLeftMenu(Convert.ToInt32(roleId), Convert.ToInt32(userId)).Data);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(_leftMenu.GetLeftMenu(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0])).Data);
        }

        [HttpGet("GetLeftMenuFull")]
        public IActionResult GetLeftMenuFull()
        {
            return Ok(_leftMenu.GetLeftMenuFull().Data);
        }
    }
}
