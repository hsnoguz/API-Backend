using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
  public  interface ITargetRiskStrategyThreatenedNeedManager
    {
        public IResult AddTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed);
        public IResult EditTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed);
        public IResult DeleteTargetRiskStrategyThreatenedNeed(int Id);
        public IResultData<TargetRiskStrategyThreatenedNeed> GetTarget_RiskStrategyThreatenedNeed(int targetId);
        public IResultData<TargetRiskStrategyThreatenedNeed> GetId_RiskStrategyThreatenedNeed(int Id);
        public IResultData<List<TargetRiskStrategyThreatenedNeed>> GetTargetRiskStrategyThreatenedNeed();
    }
}
