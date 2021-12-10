using Bussines.Abstract;
using Bussines.Concrete;
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
    public class PerformanceMatchTargetController : Controller
    {
        IPerformanceMatchTarget _performanceMatchTarget;
        public PerformanceMatchTargetController(IPerformanceMatchTarget performanceMatchTarget)
        {
            _performanceMatchTarget = performanceMatchTarget;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("MatchList")]
        public IActionResult MatchList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.MatchList().Data, jso));
        }

        [HttpGet("MatchPriceList")]
        public IActionResult MatchPriceList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.MatchPriceList().Data, jso));

        }

        [HttpGet("PerformanceMatchList")]
        public IActionResult PerformanceMatchList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformanceMatch(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]),Convert.ToInt32(User.ClaimPeriotId()[0])), jso));

        }

        [HttpGet("ListPerformanceMatchAction")]
        public IActionResult ListPerformanceMatchAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformanceMatchAction(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId()[0])), jso));
        }

        [HttpGet("ListPerformanceMatchPeriotAction")]
        public IActionResult ListPerformanceMatchPeriotAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformanceMatchPeriotAction(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId()[0])), jso));
        }

        [HttpGet("ListPerformanceMatchPeriotSubAction")]
        public IActionResult ListPerformanceMatchPeriotSubAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformanceMatchPeriotSubAction(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId()[0])), jso));
        }

        [HttpGet("ListPerformanceMatchSubAction")]
        public IActionResult ListPerformanceMatchSubAction()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformanceMatchSubAction(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId()[0])), jso));
        }

        [HttpGet("ListPerformanceMatchTarget")]
        public IActionResult ListPerformanceMatchTarget()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformanceMatchTarget(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId()[0])), jso));
        }

        [HttpGet("ListPerformancePeriotMatchTarget")]
        public IActionResult ListPerformancePeriotMatchTarget()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceMatchTarget.ListPerformancePeriotMatchTarget(User.ClaimRoles()[0], Convert.ToInt32(User.ClaimNameIdentifier()[0]), Convert.ToInt32(User.ClaimPeriotId()[0])), jso));
        }


        [HttpPost("InsertPerformanceMatch")]
        public IActionResult InsertPerformanceMatch([FromBody] PerformanceMatchTarget performanceMatch)
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            IResult result = _performanceMatchTarget.InsertPerformanceMatch(performanceMatch);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);

            }
             

        }
    }
}
