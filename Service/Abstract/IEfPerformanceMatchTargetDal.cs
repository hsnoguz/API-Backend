using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public interface IEfPerformanceMatchTargetDal
    {
        public void InsertPerformanceMatch(PerformanceMatchTarget performanceMatch);
        public List<PerformanceMatchTarget> ListPerformanceMatch(int roleId,int organizationId);
    }
}
