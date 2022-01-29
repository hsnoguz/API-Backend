using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfTargetRiskStrategyThreatenedNeedDal : IEfTargetRiskStrategyThreatenedNeedDal
    {
        IRepository<TargetRiskStrategyThreatenedNeed> _repository;
        public EfTargetRiskStrategyThreatenedNeedDal(IRepository<TargetRiskStrategyThreatenedNeed> repository)
        {
            _repository = repository;
        }
        public void AddTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed)
        {
            _repository.Insert(targetRiskStrategyThreatenedNeed);
        }

        public void DeleteTargetRiskStrategyThreatenedNeed(int Id)
        {
            var targetRiskStrategyThreatenedNeed = _repository.GetById(Id);
            _repository.Delete(targetRiskStrategyThreatenedNeed);
        }

        public void EditTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed)
        {
            var _targetRiskStrategyThreatenedNeed = _repository.GetById(targetRiskStrategyThreatenedNeed.Id);
            
            _targetRiskStrategyThreatenedNeed.Risk = targetRiskStrategyThreatenedNeed.Risk;
            _targetRiskStrategyThreatenedNeed.Strategy = targetRiskStrategyThreatenedNeed.Strategy;
            _targetRiskStrategyThreatenedNeed.Threatened = targetRiskStrategyThreatenedNeed.Threatened;
            _targetRiskStrategyThreatenedNeed.Need = targetRiskStrategyThreatenedNeed.Need;

            _repository.Delete(targetRiskStrategyThreatenedNeed);
        }

        public TargetRiskStrategyThreatenedNeed GetTarget_RiskStrategyThreatenedNeed(int targetId)
        {
            return _repository.Table.Include(x => x.Target).Where(x => x.TargetId == targetId).FirstOrDefault();
        }

        public TargetRiskStrategyThreatenedNeed GetId_RiskStrategyThreatenedNeed(int Id)
        {
            return _repository.Table.Include(x => x.Target).Where(x => x.Id == Id).FirstOrDefault();
        } 
        public List<TargetRiskStrategyThreatenedNeed> GetTargetRiskStrategyThreatenedNeed()
        {
            return _repository.Table.Include(x => x.Target).ToList();
        }
    }
}
