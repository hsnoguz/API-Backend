using DAL.Model;
using Service.Model;
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
        public void EditPerformanceTargetResult(Performance_Target_Result performanceTragetResult);
        public void EditPerformanceTargeValue(PerformancePeriotMatchTargetValue performancePeriotMatchTargetValue);
        public void EditOrganizationId(int performanceMatchId, int organizationId);
    }
}
