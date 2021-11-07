using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfPerformanceMatchTargetDal : IEfPerformanceMatchTargetDal
    {
        public void InsertPerformanceMatch(PerformanceMatchTarget performanceMatch)
        {
            throw new NotImplementedException();
        }

        public List<PerformanceMatchTarget> ListPerformanceMatch(int roleId, int organizationId)
        {
            throw new NotImplementedException();
        }
    }
}
