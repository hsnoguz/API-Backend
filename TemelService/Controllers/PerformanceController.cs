using Bussines.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Extensions;
using DAL.Model;
using Core.Results;

namespace TemelService.Controllers
{
    public class PerformanceController : Controller
    {
        IPerformanceManager _performanceManager;
        public PerformanceController(IPerformanceManager performanceManager)
        {
            _performanceManager = performanceManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("PerformanceList")]
        public IActionResult PerformanceList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.PerformanceList(Convert.ToInt32(User.ClaimNameIdentifier().ToString()), User.ClaimRoles().ToString()), jso));

        }


        [HttpGet("PerformanceAimList")]
        public IActionResult PerformanceAimList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.PerformanceAimList(), jso));
        }

        [HttpGet("PerformanceTypeList")]
        public IActionResult PerformanceTypeList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.PerformanceTypeList(), jso)); ;
        }

        [HttpPost("EditPerformanceType")]
        public IActionResult EditPerformanceType([FromBody] PerformanceType performanceType)
        {
            IResult result = _performanceManager.EditPerformanceType(performanceType);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("InsertPerformanceType")]
        public IActionResult InsertPerformanceType([FromBody] PerformanceType performanceType)
        {

            IResult result = _performanceManager.InsertPerformanceType(performanceType);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
            //return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.InsertPerformanceType(performanceType), jso)); ;
        }

        [HttpGet("Organizationlist")]
        public IActionResult Organizationlist()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.Organizationlist(), jso));

        }

        [HttpGet("PerformancePeriotList")]
        public IActionResult PerformancePeriotList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.PerformancePeriotList(), jso));

        }

        [HttpGet("PerformanceTargetList")]
        public IActionResult PerformanceTargetList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return Ok(System.Text.Json.JsonSerializer.Serialize(_performanceManager.PerformanceTargetList(Convert.ToInt32(User.ClaimNameIdentifier().ToString()), User.ClaimRoles().ToString()), jso));

        }

        [HttpPost("InsertPerformance")]
        public IActionResult InsertPerformance([FromBody] Performance performance)
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            try
            {
                return Ok(_performanceManager.InsertPerformance(performance));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
          

        }
     }
}
