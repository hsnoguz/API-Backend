using Bussines.Abstract;
using Core.Extensions;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class ActionPriceController : Controller
    {

        IActionPriceManager _actionPriceManager;
        public ActionPriceController(IActionPriceManager actionPriceManager)
        {
            _actionPriceManager = actionPriceManager;
        }

        [HttpPost("InsertActionPrice")]
        public IActionResult InsertActionPrice([FromBody]ActionPrice actionPrice)
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            IResult result = _actionPriceManager.InsertActionPrice(actionPrice);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);

            }

        }

        [HttpPost("DeleteActionPrice/{Id}")]
        public IActionResult DeleteActionPrice(int Id)
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            IResult result = _actionPriceManager.DeleteActionPrice(Id);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);

            }

        }

        [HttpPost("SetActionPriceResult/{Id}")]
        public IActionResult SetActionPriceResult(int Id,[FromBody] Decimal ResultValue)
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            IResult result = _actionPriceManager.SetActionPriceResult(Id,ResultValue);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);

            }

        }


        [HttpGet("ListActionSubActionPrice")]
        public IActionResult ListPerformanceMatchPeriotAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_actionPriceManager.ListActionSubActionPrice(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId().ToString())), jso));
        }

        [HttpGet("ListActionPrice")]
        public IActionResult ListPerformanceMatchPeriotSubAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_actionPriceManager.ListActionPrice(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId().ToString())), jso));
        }

        [HttpGet("ListSubActionPrice")]
        public IActionResult ListPerformanceMatchSubAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_actionPriceManager.ListSubActionPrice(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId().ToString())), jso));
        }
    }
}
