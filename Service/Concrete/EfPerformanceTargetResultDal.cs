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



        void IEfPerformanceTargetResultDal.InsertPerformanceTargetResult(Performance_Target_Result PerformanceTragetResult)
        {
            _repository.Insert(PerformanceTragetResult);
        }
    }
}
