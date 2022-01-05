using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfPerformanceTargetResultDal : IEfPerformanceTargetResultDal
    {
        IRepository<Performance_Target_Result> _repository;

        public EfPerformanceTargetResultDal(IRepository<Performance_Target_Result> repository)
        {
            _repository = repository;
  
        }

        public void EditOrganizationId(int performanceMatchId, int organizationId)
        {
            List<Performance_Target_Result> performance_Target_Results = _repository.Table.Where(x => x.PerformanceMatchId == performanceMatchId && x.Result== null).ToList();
            foreach (var item in performance_Target_Results)
            {
                item.OrganizationId = organizationId;
                _repository.Update(item);
            }
        }

        public void EditPerformanceTargetResult(Performance_Target_Result performanceTragetResult)
        {
            Performance_Target_Result _performanceTragetResult = _repository.GetById(performanceTragetResult.Id);
            _performanceTragetResult.Result = performanceTragetResult.Result;
            _performanceTragetResult.Explanation = performanceTragetResult.Explanation;
            _repository.Update(_performanceTragetResult);
        }

        void IEfPerformanceTargetResultDal.InsertPerformanceTargetResult(Performance_Target_Result PerformanceTragetResult)
        {
            _repository.Insert(PerformanceTragetResult);
        }
    }
}
