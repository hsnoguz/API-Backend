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
public   class PerformancePeriotService: IPerformancePeriotService
    {
        public IEfPerformancePeriotDal _efPerformancePeriotDal;
        public PerformancePeriotService(IEfPerformancePeriotDal efPerformancePeriotDal)
        {
            _efPerformancePeriotDal = efPerformancePeriotDal;
        }
        public  IResultData<List<PerformancePeriot>> PeriotList()
        {
            return new SuccessResultData<List<PerformancePeriot>>(_efPerformancePeriotDal.PeriotList());
        }
    }
}
