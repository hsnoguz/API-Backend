using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    
    [Route("Organization/[controller]")]
    [Authorize()]
    public class OrganizationController : Controller
    {
        private IListService<Organization> _OrganizationService;

        public OrganizationController(IListService<Organization> OrganizationService)
        {
            _OrganizationService = OrganizationService;
        }



        [HttpGet("organizationList")]
        public IResultData<List<Organization>>  OrganizationList()
        {
          return  _OrganizationService.getList();
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
