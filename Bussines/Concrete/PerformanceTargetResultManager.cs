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
    public class PerformanceTargetResultManager : IPerformanceTargetResultManager
    {
        IEfPerformanceTargetResultDal _efPerformanceTargetResultDal;
        public PerformanceTargetResultManager(IEfPerformanceTargetResultDal efPerformanceTargetResultDal)
        {
            _efPerformanceTargetResultDal = efPerformanceTargetResultDal;
        }
        public IResult EditOrganizationId(int performanceMatchId, int organizationId)
        {
            try
            {
                _efPerformanceTargetResultDal.EditOrganizationId(performanceMatchId, organizationId);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult EditPerformanceTargetResult(Performance_Target_Result performanceTragetResult)
        {
            try
            {
                _efPerformanceTargetResultDal.EditPerformanceTargetResult(performanceTragetResult);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult InsertPerformanceTargetResult(Performance_Target_Result performanceTragetResult)
        {
            try
            {
                _efPerformanceTargetResultDal.InsertPerformanceTargetResult(performanceTragetResult);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
    }
}
