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

    public class ProjectController : Controller
    {
        private readonly IProjectManager _projectManager;
        public ProjectController(IProjectManager projectManager)
        {
            _projectManager = projectManager;
        }

        [HttpGet("GetProject/{projectId}")]
        public IActionResult GetProject(int projectId)
        {
            var result = _projectManager.GetProjectQuestion(projectId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }
        [HttpPut("SetColumnValue")]
        public IActionResult SetColumnValue(int projectId, string columnValue, int Id)
        {
            _projectManager.SetColumnValue("p" + projectId.ToString(), columnValue, Id);
            return Ok();
        }


        [HttpPost("CreateProject")]
        public IActionResult CreateProject([FromBody] CustomProjectDto project)
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

        [HttpPost("AddProjectQuestion")]
        public IActionResult AddProjectQuestion([FromBody] Question question)
        {
            //  var result = System.Text.Json.JsonSerializer.Deserialize<Project>(json);
            IResult result = _projectManager.AddProject(question);
            return Ok();            
          /*  IResult result = _projectManager.CreateProject(project);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }*/
        }
    }
}
