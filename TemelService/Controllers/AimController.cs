﻿using Bussines.Abstract;
using Core.Extensions;
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

        [HttpGet("AimList/{periotId}")]
        public IActionResult GetAimList( int periotId)
        {
            var result = _aimManager.AimList(periotId);

            return Ok(result);
        }

        [HttpGet("GetFullList")]
        public IActionResult GetFullList()
        {
            var result = _aimManager.FullList(Convert.ToInt32(User.ClaimPeriotId().ToString()));

            return Ok(result);
        }



        [HttpPost("AddAim")]
        public IActionResult AddAim([FromBody] Aim aim)
        {
            var result = _aimManager.AddAim(aim);
            if (result.IsValid)
            {
                return Ok(aim.Id);
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

            [HttpPost("DeleteAim/{aimId}")]
        public IActionResult DeleteAim(int aimId)
        {
            var result = _aimManager.DeleteAim(aimId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
