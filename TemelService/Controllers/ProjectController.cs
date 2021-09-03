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
    [Route("project/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectManager _projectManager;
        public ProjectController(IProjectManager projectManager)
        {
            _projectManager = projectManager;
        }

        [HttpGet("GetProject/{projectId}")]
        public string GetProject(int projectId)
        {
            var result = _projectManager.GetProjectQuestion(projectId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return System.Text.Json.JsonSerializer.Serialize(result, jso);
        }


        [HttpPost("CreateProject")]
        public IActionResult CreateProject(CustomProjectDto project)
        {
            //  var result = System.Text.Json.JsonSerializer.Deserialize<Project>(json);
            IResult result=   _projectManager.CreateProject(project);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
