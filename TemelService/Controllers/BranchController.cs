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
    [Route("branch/[controller]")]
    [Authorize()]
    public class BranchController : Controller
    {
        private IListService<Branch> _branchService;

        public BranchController(IListService<Branch> branchService)
        {
            _branchService = branchService;
        }


        [Route("branch/[branchList]")]
        public IResultData<List<Branch>>  BranchList()
        {
          return  _branchService.getList();
        }

        [Route("branch/[branchAdd]")]
        public IResult BranchAdd(Branch branch)
        {

            return _branchService.Add(branch);
        }

        [Route("branch/[branchDelete]")]
        public IResult BranchDelete(Branch branch)
        {

            return _branchService.Delete(branch);
        }
    }
}
