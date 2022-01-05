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

/*
        [HttpGet("getAimList/{projectId}")]
        public IActionResult getAimList(int projectId)
        {
            var result = _projectManager.getAimList(projectId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }*/

        [HttpGet("getTargetList/{questionId}")]
        public IActionResult getTargetList(int questionId)
        {
            var result = _projectManager.getTargetList(questionId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpGet("GetProjectGuid/{guid}")]
        public IActionResult GetProjectGuid(string guid)
        {
            var result = _projectManager.GetProjectQuestionGuid(guid);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpGet("GetProjectList/{periotId}")]
        public IActionResult GetProjectList(int periotId)
        {
            var result = _projectManager.Projects(periotId);
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(result, jso));
        }

        [HttpPost("SetColumnValue")]
        public IActionResult SetColumnValue([FromBody] ProjectColumnValueDto projectColumnValue)
        {
         var result=   _projectManager.SetColumnValue(projectColumnValue);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
            
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
            IResultData<int> result = _projectManager.AddProjectQuestion(question);

            if (result.IsValid)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
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



        [HttpPost("AddProjectQuestionHorizontal")]
        public IActionResult AddProjectQuestionHorizontal([FromBody] QuestionHorizontal question)
        {
            //  var result = System.Text.Json.JsonSerializer.Deserialize<Project>(json);
            IResultData<int> result = _projectManager.addQuestionHorizantalAdd(question);
            if (result.IsValid)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
            [HttpPost("EditQuestion")]
        public IActionResult EditQuestion([FromBody] Question question)
        {

           IResult result= _projectManager.EditQuestion(question);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

       [HttpPost("EditQuestionIndex")]
        public IActionResult EditQuestionIndex([FromBody] List<EditProjectIndexDto> listEditProjectIndexDto)
        {
            //  var result = System.Text.Json.JsonSerializer.Deserialize<Project>(json);
            IResult result = _projectManager.EditQuestionIndex(listEditProjectIndexDto);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("InsertSurvey/{guid}")]
        public IActionResult InsertSurvey(string guid)
        {
            IResultData<int> result = _projectManager.insertSurvey(guid);

            if (result.IsValid)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("SendSurveyStatu")]
        public IActionResult SendSurveyStatu(int projectId,Int16 statu,int Id)
        {
            IResult result = _projectManager.SendSurveyStatu("p" + projectId.ToString(), projectId,statu,Id);


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
