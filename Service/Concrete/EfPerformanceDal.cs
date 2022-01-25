using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Abstract;
using Service.Enum;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfPerformanceDal : IEfPerformanceDal
    {
       
        IRepository<Performance> _repository;
        IEfPerformancePeriotDal _PerformancePeriot;
        IEfOperationServiceDal _efOperationServiceDal;
        IEfOrganizationServiceDal _efOrganizationServiceDal;

        ManagerContext _context;
        public EfPerformanceDal(IRepository<Performance> repository, ManagerContext context, IEfOrganizationServiceDal efOrganizationServiceDal, IEfOperationServiceDal efOperationServiceDal, IEfPerformancePeriotDal PerformancePeriot)
        {
            _repository = repository;
            _PerformancePeriot = PerformancePeriot;
            _context = context;
         //   _iEfPerformanceTargetResultDal = iEfPerformanceTargetResultDal;
            _efOperationServiceDal = efOperationServiceDal;
            _efOrganizationServiceDal = efOrganizationServiceDal;
            
        }

        public List<Performance> PerformanceList(int organizationId, int roleId)
        {
            int AdminRoleID = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList=_efOrganizationServiceDal.OrganizationDalList(organizationId);

           return _repository.Table.Include(x=>x.PerformanceAim).Include(x => x.PerformanceType).Include(x=>x.PerformancePeriot).Where(x => roleId == AdminRoleID /*|| organizationIdList.Contains(x.OrganizationId)*/).ToList();
        }

        public List<Performance> PerformancePeriot(int PerformanceId)
        {
            return _repository.Table.Include(x => x.Performance_Target_Results).Include(x => x.PerformanceAim).Include(x => x.PerformanceType).Include(x => x.PerformancePeriot).Where(x => x.Id==PerformanceId).ToList();
        }

        public void DeletePerformance(int performanceId)
        {
            var performance = _repository.GetById(performanceId);
            _repository.Delete(performance);
        }
        public Performance getPerformance(int Id)
        {
            return _repository.Table.Include(x => x.PerformanceAim).Include(x => x.PerformanceType).Include(x => x.PerformancePeriot).Where(x=>x.Id==Id).FirstOrDefault();
        }

        public List<Performance> PerformancePeriotList(int organizationId, int roleId)
        {
            int AdminRoleID = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);

            return _repository.Table.Include(x => x.Performance_Target_Results).Include

                (x => x.PerformanceAim).Include(x => x.PerformanceType).Include(x => x.PerformancePeriot).Where(x => roleId == AdminRoleID /*|| organizationIdList.Contains(x.OrganizationId)*/).ToList();
        }

        public void InsertPerformance(Performance Performance)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _repository.Insert(Performance);
                /*    Int16 PerformancePeriotValue = _PerformancePeriot.PeriotValue(Performance.PerformancePeriotId);
                    var target = Performance.TargetValue;
                    decimal tempTarget = Performance.TargetValue;
                    int yearRange = (Performance.StopYear - Performance.StartYear) + 1;
                    int timeRange = (yearRange * 12) / PerformancePeriotValue;
                    DateTime targetTime = new DateTime();//= new DateTime(Performance.StartYear,Performance.StartMonth,Performance.StartDay);
                    decimal tempValue = Performance.BaseValue;

                    for (Int16 i = 0; i < timeRange; i++)
                    {
                        var target_result = new Performance_Target_Result();
                        target_result.PerformanceId = Performance.Id;


                        tempValue= PeriotTargetValue(Performance.PerformanceAimId, tempValue, Performance.TargetValue);
                        target_result.Target = tempValue;
                        if (i == 0) {
                            targetTime = new DateTime(Performance.StartYear, Performance.StartMonth, Performance.StartDay);
                        }
                        else {
                            targetTime = targetTime.AddMonths(PerformancePeriotValue);
                        }
                        target_result.TargetTime = targetTime;
                        target_result.PerformanceId = Performance.Id;
                        _iEfPerformanceTargetResultDal.InsertPerformanceTargetResult(target_result);

                    }*/
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
         
        }

     
    }
}
