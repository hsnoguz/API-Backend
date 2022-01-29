using Bussines.Abstract;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    public class TargetRiskStrategyThreatenedNeedController : Controller
    {
        ITargetRiskStrategyThreatenedNeedManager _targetRiskStrategyThreatened;
        public TargetRiskStrategyThreatenedNeedController(ITargetRiskStrategyThreatenedNeedManager targetRiskStrategyThreatened)
        {
            _targetRiskStrategyThreatened = targetRiskStrategyThreatened;
        }

        [HttpPost("AddTargetRiskStrategyThreatenedNeed")]
        public IActionResult AddTargetRiskStrategyThreatenedNeed([FromBody]TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed)
        {
            var result = _targetRiskStrategyThreatened.AddTargetRiskStrategyThreatenedNeed(targetRiskStrategyThreatenedNeed);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("EditTargetRiskStrategyThreatenedNeed")]
        public IActionResult EditTargetRiskStrategyThreatenedNeed([FromBody] TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed)
        {
            var result = _targetRiskStrategyThreatened.EditTargetRiskStrategyThreatenedNeed(targetRiskStrategyThreatenedNeed);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpPost("DeleteTargetRiskStrategyThreatenedNeed/{Id}")]
        public IActionResult DeleteTargetRiskStrategyThreatenedNeed(int Id)
        {
            var result = _targetRiskStrategyThreatened.DeleteTargetRiskStrategyThreatenedNeed(Id);
            if (result.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpGet("GetTarget_RiskStrategyThreatenedNeed/{targetId}")]
        public IActionResult GetTarget_RiskStrategyThreatenedNeed(int targetId)
        {
            var result = _targetRiskStrategyThreatened.GetTarget_RiskStrategyThreatenedNeed(targetId);
          
            return Ok(result.Data);
           
        }

        [HttpGet("GetId_RiskStrategyThreatenedNeed/{Id}")]
        public IActionResult GetId_RiskStrategyThreatenedNeed(int Id)
        {
            var result = _targetRiskStrategyThreatened.GetId_RiskStrategyThreatenedNeed(Id);

            return Ok(result.Data);

        }

        [HttpGet("GetTargetRiskStrategyThreatenedNeed")]
        public IActionResult GetTargetRiskStrategyThreatenedNeed()
        {
            var result = _targetRiskStrategyThreatened.GetTargetRiskStrategyThreatenedNeed();

            return Ok(result.Data);

        }
        
    }
}
