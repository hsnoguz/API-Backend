using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class TargetRiskStrategyThreatenedNeedManager : ITargetRiskStrategyThreatenedNeedManager
    {
        IEfTargetRiskStrategyThreatenedNeedDal _efTargetRiskStrategyThreatenedNeedDal;
        public TargetRiskStrategyThreatenedNeedManager(IEfTargetRiskStrategyThreatenedNeedDal efTargetRiskStrategyThreatenedNeedDal)
        {
            _efTargetRiskStrategyThreatenedNeedDal = efTargetRiskStrategyThreatenedNeedDal;
        }

        public IResult AddTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed)
        {
            try
            {
                _efTargetRiskStrategyThreatenedNeedDal.AddTargetRiskStrategyThreatenedNeed(targetRiskStrategyThreatenedNeed);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult DeleteTargetRiskStrategyThreatenedNeed(int Id)
        {
            try
            {
                _efTargetRiskStrategyThreatenedNeedDal.DeleteTargetRiskStrategyThreatenedNeed(Id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult EditTargetRiskStrategyThreatenedNeed(TargetRiskStrategyThreatenedNeed targetRiskStrategyThreatenedNeed)
        {
            try
            {
                _efTargetRiskStrategyThreatenedNeedDal.EditTargetRiskStrategyThreatenedNeed(targetRiskStrategyThreatenedNeed);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResultData<TargetRiskStrategyThreatenedNeed> GetId_RiskStrategyThreatenedNeed(int Id)
        {
            return new SuccessResultData<TargetRiskStrategyThreatenedNeed>(_efTargetRiskStrategyThreatenedNeedDal.GetId_RiskStrategyThreatenedNeed(Id));
        }

        public IResultData<List<TargetRiskStrategyThreatenedNeed>> GetTargetRiskStrategyThreatenedNeed()
        {
            return new SuccessResultData<List<TargetRiskStrategyThreatenedNeed>>(_efTargetRiskStrategyThreatenedNeedDal.GetTargetRiskStrategyThreatenedNeed());
        }

        public IResultData<TargetRiskStrategyThreatenedNeed> GetTarget_RiskStrategyThreatenedNeed(int targetId)
        {
            return new SuccessResultData<TargetRiskStrategyThreatenedNeed>(_efTargetRiskStrategyThreatenedNeedDal.GetTarget_RiskStrategyThreatenedNeed(targetId));
        }
    }
}
