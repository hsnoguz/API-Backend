using Bussines.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class OperationClaimController : Controller
    {
        private readonly IOperationClaimManager  _operationClaimManager;
        public OperationClaimController(IOperationClaimManager operationClaimManager)
        {
            _operationClaimManager = operationClaimManager;
        }

        [HttpGet("GetOparationClaimList")]
        public IActionResult GetOparationClaimList()
        {
            return Ok(_operationClaimManager.OperationClaimList().Data);
        }

        [HttpPost("DeleteOperationClaim/{Id}")]
        public IActionResult DeleteOperationClaim(int Id)
        {
            return Ok(_operationClaimManager.DeleteOperationClaim(Id));
        }

        [HttpPost("EditOperationClaim")]
        public IActionResult EditOperationClaim(OperationClaim operationClaim)
        {
            return Ok(_operationClaimManager.EditOperationClaim(operationClaim));
        }

        [HttpPost("AddOperationClaim")]
        public IActionResult AddOperationClaim(string name)
        {
            return Ok(_operationClaimManager.AddOperationClaim(name));
        }
    }
}
