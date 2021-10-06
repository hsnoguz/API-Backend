using Bussines.Abstract;
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
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpGet("ActionListFull")]
        public IActionResult ActionListFull()
        {
            var result = _ActionManager.ActionListFull();
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpPost("AddAction")]
        public IActionResult AddAction([FromBody] DAL.Model.Action Action)
        {
            var result = _ActionManager.AddAction(Action);
            if (result.IsValid)
            {
                return Ok();
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
