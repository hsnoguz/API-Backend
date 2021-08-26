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


        [Route("Organization/[organizationList]")]
        public IResultData<List<Organization>>  OrganizationList()
        {
          return  _OrganizationService.getList();
        }

        [Route("Organization/[organizationAdd]")]
        public IResult OrganizationAdd(Organization Organization)
        {

            return _OrganizationService.Add(Organization);
        }

        [Route("Organization/[organizationDelete]")]
        public IResult OrganizationDelete(Organization Organization)
        {

            return _OrganizationService.Delete(Organization);
        }
    }
}
