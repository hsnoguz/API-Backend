﻿using Bussines.Abstract;
using Bussines.Service.Abstract;
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
        private IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }


        [HttpGet("branchList")]
        public IResultData<List<Branch>>  BranchList()
        {

          return  _branchService.getList();
        }

        [HttpPost("jopAdd")]
        public IActionResult BranchAdd(Branch branch)
        {
            IResult result = _branchService.Add(branch);

            if (result.IsValid)
                return Ok();
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpDelete("branchDelete")]
        public IActionResult BranchDelete(Branch branch)
        {
            IResult result = _branchService.Delete(branch);

            if (result.IsValid)
                return Ok();
            else
            {
                return BadRequest(result.Message);
            }
          
        }
    }
}