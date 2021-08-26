using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Core.Entities.Concrete;
using Core.Results;
using Bussines.Concrete;
using Bussines.Abstract;
using System.Text.Json;
using Newtonsoft.Json;

namespace TemelService.Controllers
{
    [ApiController]
    [Route("west/[controller]")]
    public class WeatherForecastController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ManagerContext _manager;
        private readonly IProjectManager _projectManager;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ManagerContext manager, IProjectManager projectManager)
        {
            _manager = manager;
            var user = _manager.Set<User>();
            _projectManager = projectManager;
            _logger = logger;
        }

        [HttpGet("GetProject/{projectId}")]
        public string GetProject(int projectId)
        {
            var result = _projectManager.GetProjectQuestion(projectId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return System.Text.Json.JsonSerializer.Serialize(result,jso);
        }


        [HttpPost("SetProject")]
        public IResult SetProject(Project json)
        {
          //  var result = System.Text.Json.JsonSerializer.Deserialize<Project>(json);
            return new SuccessResult("sdsad");
        }


        [HttpGet("Test")]
        public IResult GetProject2()
        {
            return new SuccessResult(true, "Selam");
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
