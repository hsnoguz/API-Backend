using Bussines.Service.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public class PerformanceAimService : IPerformanceAimService
    {
        public IEfPerformanceAimDal _efPerformanceAimDal;
        public PerformanceAimService(IEfPerformanceAimDal efPerformanceAimDal)
        {
            _efPerformanceAimDal = efPerformanceAimDal;
        }
        public IResultData<List<PerformanceAim>> PerformanceAimList()
        {
            return new SuccessResultData<List<PerformanceAim>>(_efPerformanceAimDal.PerformanceAimList());
        }
    }
}
