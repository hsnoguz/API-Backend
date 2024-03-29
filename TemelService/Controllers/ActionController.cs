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
using Action = DAL.Model.Action;

namespace TemelService.Controllers
{

    [Route("[controller]")]

    public class ActionController : Controller
    {
        private readonly IActionManager _ActionManager;
        public ActionController(IActionManager ActionManager)
        {
            _ActionManager = ActionManager;
        }

        [HttpGet("ActionList/{targetId}")]
        public IActionResult GetActionList(int targetId)
        {
            var result = _ActionManager.ActionList(targetId);

            return Ok(result);
        }
/*
        [HttpGet("ActionListFull")]
        public IActionResult ActionListFull()
        {
            var result = _ActionManager.ActionListFull(Convert.ToInt32(User.ClaimPeriotId().ToString()));

            return Ok(result);
        }
*/
        [HttpGet("ActionListFull")]
        public IActionResult ActionTargetAimList()
        {
            var result = _ActionManager.ActionTargetAimList(Convert.ToInt32(User.ClaimPeriotId().ToString()));

            return Ok(result);
        }

        [HttpGet("GetAction_OrganizationId/{actionId}")]
        public IActionResult GetAction_OrganizationId(int actionId)
        {
            var result = _ActionManager.GetOrganizationId(actionId).Data;

            return Ok(result);
        }

        [HttpPost("EditTarget/{id}")]
        public IActionResult EditTarget(int id, int targetId) {
            var result = _ActionManager.EditTarget(id,targetId);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("EditAction")]
        public IActionResult EditAction([FromBody] Action action) {
            var result = _ActionManager.EditAction(action);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpPost("AddAction")]
        public IActionResult AddAction([FromBody] DAL.Model.Action Action)
        {
            var result = _ActionManager.AddAction(Action);
            if (result.IsValid)
            {
                return Ok(Action.Id);
            }
            else
            {
                return BadRequest(result.Message);
            }
               
        }

        [HttpPost("DeleteAction/{ActionId}")]
        public IActionResult GetProjectList(int ActionId)
        {
            var result = _ActionManager.DeleteAction(ActionId);
            if (result.IsValid)
             return Ok();
            else
                return BadRequest(result.Message);
        }    }
}
