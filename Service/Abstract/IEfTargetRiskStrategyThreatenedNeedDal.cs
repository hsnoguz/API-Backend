using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfTargetRiskStrategyThreatenedNeedDal
    {
        public void AddTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed);
        public void EditTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed);
        public void DeleteTargetRiskStrategyThreatenedNeed(int Id);
        public TargetRiskStrategyThreatenedNeed GetTarget_RiskStrategyThreatenedNeed(int targetId);
        public TargetRiskStrategyThreatenedNeed GetId_RiskStrategyThreatenedNeed(int Id);
        public List<TargetRiskStrategyThreatenedNeed> GetTargetRiskStrategyThreatenedNeed();

    }
}
