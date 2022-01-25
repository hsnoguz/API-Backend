using Core.Results;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
 public   interface IPerformanceTargetResultManager
    {
        public IResult InsertPerformanceTargetResult(Performance_Target_Result performanceTragetResult);
        public IResult EditPerformanceTargetResult(Performance_Target_Result performanceTragetResult);
        public IResult EditPerformanceTargeValue(PerformancePeriotMatchTargetValue performancePeriotMatchTargetValue);
        public IResult EditOrganizationId(int performanceMatchId, int organizationId);

    }
}
