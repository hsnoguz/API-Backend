using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    
    [Route("Organization/[controller]")]

    public class OrganizationController : Controller
    {
        private IListService<Organization> _OrganizationService;

        public OrganizationController(IListService<Organization> OrganizationService)
        {
            _OrganizationService = OrganizationService;
        }



        [HttpGet("organizationList")]
        public IActionResult OrganizationList()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            return Ok(System.Text.Json.JsonSerializer.Serialize(_OrganizationService.getList().Data, jso));
            
        }

        
        [HttpPost("organizorganizationAddationDelete")]
        public IActionResult OrganizationAdd(Organization Organization)
        {
            IResult result = _OrganizationService.Add(Organization);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
         
        }

     
        [HttpDelete("organizationDelete")]
        public IActionResult OrganizationDelete(Organization Organization)
        {
            IResult result = _OrganizationService.Delete(Organization);
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
