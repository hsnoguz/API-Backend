using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IEfPerformanceTargetResultDal
    {
        public void InsertPerformanceTargetResult(Performance_Target_Result performanceTragetResult);
   
        public void EditOrganizationId(int performanceMatchId, int organizationId);
    }
}
