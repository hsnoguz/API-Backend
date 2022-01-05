using Core.Entities.Concrete;
using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
   public interface IPerformanceManager
    {
        
        public IResult InsertPerformance(Performance Performance);
        public IResult DeletePerformance(int Id);
        public IResultData<List<Performance>> PerformanceList(int userId,string roleName);
        public IResultData<List<Organization>> Organizationlist();
        public IResultData<List<PerformanceAim>> PerformanceAimList();

        public IResultData<List<Performance>> PerformanceTargetList(int userId, string roleName);
        public IResultData<List<Performance>> PerformanceTarget(int PerformanceId);

        public IResultData<List<PerformancePeriot>> PerformancePeriotList();
        public IResultData<List<PerformanceType>> PerformanceTypeList();
        public IResult EditPerformanceType(PerformanceType performanceType);
        public IResult InsertPerformanceType(PerformanceType performanceType);

        public IResultData<Periot> CurrentPeriot(int Id);
    }
}
