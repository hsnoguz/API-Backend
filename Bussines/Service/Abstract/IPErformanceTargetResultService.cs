using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
  public  interface IPErformanceTargetResultService
    {
        public IResult InsertIndicatorTargetResult(Performance_Target_Result ındicator_Target_Result);
        public List<Performance> IndicatorTargetList(int IndicatorId);
        public List<Performance> IndicatorTargetListFull(int organizationId, int roleId);
    }
}
