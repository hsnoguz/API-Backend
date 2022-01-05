using Bussines.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class UserLeftMenuClaimController : Controller
    {
        IUserLeftMenuClaim _userLeftMenuClaim;
        public UserLeftMenuClaimController(IUserLeftMenuClaim userLeftMenuClaim)
        {
            _userLeftMenuClaim = userLeftMenuClaim;
        }


        [HttpPost("AddUserLeftMenuClaim/{roleId}/{leftmenuId}")]
        public IActionResult AddUserLeftMenuClaim(int roleId,int leftmenuId)
        {
            
            var result = _userLeftMenuClaim.AddUserLeftMenuClaim(roleId,leftmenuId);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
                
            }
        }

        [HttpPost("DeleteLeftMenuClaim/{Id}")]
        public IActionResult DeleteLeftMenuClaim(int Id)
        {
            var result = _userLeftMenuClaim.DeleteUserLeftMenuClaim(Id);
            if (result.IsValid)
            {
                return Ok();
                
            }
            else
            {
                return BadRequest(result.Message);
            }
        }


        [HttpGet("ListLeftMenuClaim")]
        public IActionResult ListLeftMenuClaim()
        {
            return Ok(_userLeftMenuClaim.ListUserLeftMenuClaim().Data);
        }
        }
}
