
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
using Core.Extensions;
using Service.Model;

namespace Service.Concrete
{
    public class EfPerformanceMatchTargetDal : IEfPerformanceMatchTargetDal
    {
        IEfListServiceDal<Match> _matchList;
        IRepository<PerformanceMatchTarget> _repository;
        IEfPerformancePeriotDal _efPerformancePeriotDal;
        IEfOrganizationServiceDal _efOrganizationServiceDal;
        IEfPerformanceDal _efPerformanceDal;
        ManagerContext _context;
        IEfPerformanceTargetResultDal _iEfPerformanceTargetResultDal;
        IEfOperationServiceDal _efOperationServiceDal;
        public EfPerformanceMatchTargetDal(IEfListServiceDal<Match> matchList, 
            IEfPerformanceTargetResultDal iEfPerformanceTargetResultDal,
            ManagerContext context,
            IEfPerformanceDal efPerformanceDal,
            IEfPerformancePeriotDal efPerformancePeriotDal,
            IRepository<PerformanceMatchTarget> repository,
            IEfOrganizationServiceDal efOrganizationServiceDal,
            IEfOperationServiceDal efOperationServiceDal
            )
        {
            _matchList = matchList;
            _repository = repository;
            _context = context;
            _iEfPerformanceTargetResultDal=iEfPerformanceTargetResultDal;
            _efPerformancePeriotDal = efPerformancePeriotDal;
            _efPerformanceDal = efPerformanceDal;
            _efOrganizationServiceDal = efOrganizationServiceDal;
            _efOperationServiceDal = efOperationServiceDal;
        }

        public void InsertPerformanceMatch(PerformanceMatchTarget performanceMatch)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Performance performance = _efPerformanceDal.getPerformance(performanceMatch.PerformanceId);
                    Int16 PerformancePeriotValue = _efPerformancePeriotDal.PeriotValue(performance.PerformancePeriotId);
                    var target = performance.TargetValue;
                    decimal tempTarget = performance.TargetValue;
                    int yearRange = (performance.StopYear - performance.StartYear) + 1;
                    int timeRange = (yearRange * 12) / PerformancePeriotValue;
                    DateTime targetTime = new DateTime();//= new DateTime(Performance.StartYear,Performance.StartMonth,Performance.StartDay);
                    decimal tempValue = performance.BaseValue;

                    PerformanceMatchTarget match = new PerformanceMatchTarget();
                    match.PerformanceId = performance.Id;
                    match.MatchId = performanceMatch.MatchId;
                    match.TargetId = performanceMatch.TargetId;
                    //     match.ActionId = match.ActionId;
                    match.OrganizationId = performanceMatch.OrganizationId;
                    //     match.SubActionId = match.SubActionId;
                    _repository.Insert(match);

                    for (Int16 i = 0; i < timeRange; i++)
                    {
                        var target_result = new Performance_Target_Result();
                        target_result.PerformanceId = performance.Id;

                        target_result.PerformanceMatchId = match.Id;
                        target_result.TargetId = match.TargetId;
                        target_result.OrganizationId = performanceMatch.OrganizationId;
                        tempValue = PeriotTargetValue(performance.PerformanceAimId, tempValue, performance.TargetValue);
                        target_result.Target = tempValue;
                        if (i == 0)
                        {
                            targetTime = new DateTime(performance.StartYear, performance.StartMonth, performance.StartDay);
                        }
                        else
                        {
                            targetTime = targetTime.AddMonths(PerformancePeriotValue);
                        }
                        target_result.TargetTime = targetTime;
                        target_result.PerformanceId = performance.Id;
                         _iEfPerformanceTargetResultDal.InsertPerformanceTargetResult(target_result);

                    }

                    

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
          //  throw new NotImplementedException();
  
        }

        public List<PerformanceMatchDto> ListPerformanceMatch(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);
            List<PerformanceMatchDto> matchList = (from PM in _context.PerformanceMatchTargets where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId==periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id
                                                   join T in _context.Targets.DefaultIfEmpty() 
                                                        on new { Id= PM.TargetId, key2=M.Explanation }
                                                          equals 
                                                        new { Id=T.Id, key2="Hedef" }
                                                        into resut1 from resultH in resut1.DefaultIfEmpty()
                                                   join A in _context.Actions.DefaultIfEmpty()
                                                        on new { Id = PM.TargetId, key2 = M.Explanation }
                                                        equals
                                                        new { Id = A.Id, key2 = "Faaliyet" }
                                                         into resut2
                                                   from resultFa in resut2.DefaultIfEmpty()
                                                   join SA in _context.SubActions.DefaultIfEmpty() 
                                                        on new { Id = PM.TargetId, key2 = M.Explanation }
                                                        equals
                                                        new { Id = SA.Id, key2 = "Alt Faaliyet" }
                                                              into resut3
                                                   from resultAFa in resut3.DefaultIfEmpty()
                                                   join PP in _context.PerformancePeriots
                                                   on PM.Performance.PerformancePeriotId equals PP.Id
                                                   join PPTR in  _context.Performance_Target_Results.Where(x=>x.IsEntry==true).GroupBy(x=> new{ x.PerformanceMatchId,x.PerformanceId, x.TargetId })
                                                  .Select(x => new PerformanPeriotGroupDto() { TargetId =x.Key.TargetId , PerformanceId = x.Key.PerformanceId, PerformanceMatchId = x.Key.PerformanceMatchId,Target= x.Sum(s => s.Target),Result= x.Sum(s => s.Result) })
                                            
                                                   //.GroupBy(x=> { x.PerformanceMatchId,x.PerformanceId,x.TargetId}) PPTR by PPTR.PerformanceId  into ppt
                                                    on new { key2 = PM.PerformanceId, key1 = PM.MatchId, key3 =PM.TargetId }
                                                        equals
                                                    new {  key2 =PPTR.PerformanceId, key1 = PPTR.PerformanceMatchId, key3 = PPTR.TargetId }
                                                    into result4
                                                   from resultPPTR in result4.DefaultIfEmpty()
                                                   select new PerformanceMatchDto() {
                                                       Id = PM.Id,
                                                       PerformanceExplanation=PM.Performance.Explanation,
                                                       PerformancePeriotExplanation=PP.Explanation,
                                                       MatchExplanation =M.Explanation,
                                                       TargetExplanation=(
                                                       M.Id==1? resultH.Explanation:
                                                       M.Id == 2 ? resultFa.Explanation :
                                                       M.Id == 3 ? resultAFa.Explanation :""
                                                       ),
                                                       BaseValue =PM.Performance.BaseValue,
                                                       TargetValue= PM.Performance.TargetValue,
                                                       SumTargetValue =resultPPTR.Target == null ? 0 : resultPPTR.Target,
                                                       SuccessRate = resultPPTR.Result == null ? 0 : (resultPPTR.Result / resultPPTR.Target) * 100  
                                                   }
                                                     ).ToList();

            /*  _repository.GetSql(
              "select * from PerformanceMatchTarget as PM" +
              " left join Target as T on PM.TargetId=T.Id and PM.MatchId=1 " +
              " left join Action as A on PM.TargetId=A.Id and PM.MatchId=2 " +
              " left join SubAction as S on PM.TargetId=S.Id and PM.MatchId=3 "
              ).Select<PerformanceMatchTarget>(new (x=>x.));*/
            return matchList;


        }

        public List<PerformanceMatchDto> ListPerformanceMatchTarget(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);
            List<PerformanceMatchDto> matchList = (from PM in _context.PerformanceMatchTargets
                                                   where  ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id
                                                   join T in _context.Targets.DefaultIfEmpty()
                                                        on new { Id = PM.TargetId, key2 = M.Explanation }
                                                          equals
                                                        new { Id = T.Id, key2 = "Hedef" }
                                                        into resut1
                                                   from resultH in resut1.DefaultIfEmpty()
                                                   join PP in _context.PerformancePeriots
                                                    on PM.Performance.PerformancePeriotId equals PP.Id
                                                   select new PerformanceMatchDto()
                                                   {
                                                       Id = PM.Id,
                                                       PerformanceExplanation = PM.Performance.Explanation,
                                                       PerformancePeriotExplanation=PP.Explanation,
                                                       MatchExplanation = M.Explanation,
                                                       TargetExplanation = resultH.Explanation,
                                                       BaseValue = PM.Performance.BaseValue,
                                                       TargetValue = PM.Performance.TargetValue
                                                   }
                                                     ).ToList();
            return matchList;
        }

        public List<PerformanceMatchDto> ListPerformanceMatchAction(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);
            List<PerformanceMatchDto> matchList = (from PM in _context.PerformanceMatchTargets
                                                   where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id
                                                   join A in _context.Actions.DefaultIfEmpty()
                                                       on new { Id = PM.TargetId, key2 = M.Explanation }
                                                       equals
                                                       new { Id = A.Id, key2 = "Faaliyet" }
                                                        into resut2
                                 
                                                   from resultFa in resut2.DefaultIfEmpty()
                                                   join PP in _context.PerformancePeriots
                                                   on PM.Performance.PerformancePeriotId equals PP.Id
                                                   select new PerformanceMatchDto()
                                                   {
                                                       Id = PM.Id,
                                                       PerformanceExplanation = PM.Performance.Explanation,
                                                       PerformancePeriotExplanation=PP.Explanation,
                                                       MatchExplanation = M.Explanation,
                                                       TargetExplanation = resultFa.Explanation,
                                                       BaseValue = PM.Performance.BaseValue,
                                                       TargetValue = PM.Performance.TargetValue
                                                   }
                                                     ).ToList();
            return matchList;
        }


        public List<PerformanceMatchDto> ListPerformanceMatchSubAction(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);
            List<PerformanceMatchDto> matchList = (from PM in _context.PerformanceMatchTargets
                                                   where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id
                                                   join SA in _context.SubActions.DefaultIfEmpty()
                                                      on new { Id = PM.TargetId, key2 = M.Explanation }
                                                      equals
                                                      new { Id = SA.Id, key2 = "Alt Faaliyet" }
                                                            into resut3
                                                   from resultAFa in resut3.DefaultIfEmpty()
                                                   join PP in _context.PerformancePeriots
                                                   on PM.Performance.PerformancePeriotId equals PP.Id
                                                   select new PerformanceMatchDto()
                                                   {
                                                       Id = PM.Id,
                                                       PerformanceExplanation = PM.Performance.Explanation,
                                                       PerformancePeriotExplanation = PP.Explanation,
                                                       MatchExplanation = M.Explanation,
                                                       TargetExplanation = resultAFa.Explanation,
                                                       BaseValue = PM.Performance.BaseValue,
                                                       TargetValue = PM.Performance.TargetValue
                                                   }
                                                     ).ToList();
            return matchList;
        }




        public List<PerformancePeriotMatchDto> ListPerformancePeriotMatchTarget(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);

            var performansPeriotList = (from PP in _context.Performance_Target_Results
                                        join P in _context.Performances

                                             on PP.PerformanceId equals P.Id
                                        /*   join PA in _context.PerformanceAims
                                                on P.PerformanceAimId equals PA.Id*/
                                        join PM in _context.PerformanceMatchTargets
                                          on new { key2 = PP.PerformanceId, key1 = PP.PerformanceMatchId, key3 = PP.TargetId }
                                                        equals
                                           new { key2 = PM.PerformanceId, key1 = PM.MatchId, key3 = PM.TargetId }

                                        where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId == periotId)
                                        join M in (_context.Matchs)
                                            on PM.MatchId equals M.Id
                                        where M.Explanation == "Hedef"
                                        join A in (_context.Actions)
                                        on PM.TargetId equals A.Id
                                        select new PerformancePeriotMatchDto()
                                        {
                                            Id=PP.Id,
                                            PerformanceExplanation = P.Explanation,
                                            AimExplanation = A.Explanation,
                                            ResultExplanation = PP.Explanation,
                                            TargetTime =PP.TargetTime,

                                            //     P.PerformanceAim.Explanation,
                                            TargetValue= PP.Target,
                                            ResultValue= PP.Result
                                        }
                         ).ToList();
            return performansPeriotList;
        }

        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotAction(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);

            var performansPeriotList = (from PP in _context.Performance_Target_Results
                                        join P in _context.Performances
                                             on PP.PerformanceId equals P.Id
                                        /*   join PA in _context.PerformanceAims
                                                on P.PerformanceAimId equals PA.Id*/
                                        join PM in _context.PerformanceMatchTargets
                                            on new { key2 = PP.PerformanceId, key1 = PP.PerformanceMatchId, key3 = PP.TargetId }
                                                        equals
                                           new { key2 = PM.PerformanceId, key1 = PM.MatchId, key3 = PM.TargetId }
                                        where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId == periotId)
                                        join M in (_context.Matchs)
                                            on PM.MatchId equals M.Id
                                        where M.Explanation == "Faaliyet"
                                        join A in (_context.Actions)
                                          on PM.TargetId equals A.Id
                                        select new PerformancePeriotMatchDto()
                                        {
                                            Id = PP.Id,
                                            PerformanceExplanation = P.Explanation,
                                            AimExplanation = A.Explanation,
                                            ResultExplanation = PP.Explanation,
                                            TargetTime = PP.TargetTime,

                                            //     P.PerformanceAim.Explanation,
                                            TargetValue = PP.Target,
                                            ResultValue = PP.Result
                                        }
                         ).ToList();
            return performansPeriotList;
        }

        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotSubAction(int roleId, int organizationId,int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);
          

            var performansPeriotList = (from PP in _context.Performance_Target_Results
                                        join P in _context.Performances
                                             on PP.PerformanceId equals P.Id
                                        join PM in _context.PerformanceMatchTargets
                                            on new { key2 = PP.PerformanceId, key1 = PP.PerformanceMatchId, key3 = PP.TargetId }
                                            equals
                                           new { key2 = PM.PerformanceId, key1 = PM.MatchId, key3 = PM.TargetId }
                                        where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.Performance.PeriotId == periotId)

                                        join M in (_context.Matchs)
                                            on PM.MatchId equals M.Id
                                        where M.Explanation == "Alt Faaliyet"
                                        join SA in (_context.SubActions)
                                        on PM.TargetId equals SA.Id
                                        select new PerformancePeriotMatchDto()
                                        {
                                            Id = PP.Id,

                                            PerformanceExplanation = P.Explanation,
                                            AimExplanation = SA.Explanation,
                                            ResultExplanation = PP.Explanation,
                                            TargetTime = PP.TargetTime,

                                            //     P.PerformanceAim.Explanation,
                                            TargetValue = PP.Target,
                                            ResultValue = PP.Result
                                        }
              ).ToList();
            return performansPeriotList;
        }

        public List<Match> MatchList()
        {
            return _matchList.Table.ToList();
        }
        public List<Match> MatchPriceList()
        {
            string[] FaaliyetList = { "Faaliyet", "Alt Faaliyet" };
            return _matchList.Table.Where(x=> FaaliyetList.Contains(x.Explanation)).ToList();
        }
        public decimal PeriotTargetValue(int PerformanceAimId, decimal tempValue, decimal targetValue)
        {
            decimal result = 0;
            switch (PerformanceAimId)
            {
                case (int)EnumPerformanceAim.Yuzdesel_Artis:
                    result = tempValue + ((tempValue * targetValue) / 100);
                    break;
                case (int)EnumPerformanceAim.Yuzdesel_Azalis:
                    result = tempValue - ((tempValue * targetValue) / 100);
                    break;
                case (int)EnumPerformanceAim.Rakamsal_Artis:
                    result = tempValue + targetValue;
                    break;
                case (int)EnumPerformanceAim.Rakamsal_Azalis:
                    result = tempValue - targetValue;
                    break;
                default:
                    result = targetValue;
                    break;
            }

            return result;


        }

        public void EditOrganizationId(int matchId, int targetId, int organizationId)
        {
            PerformanceMatchTarget performanceMatchTarget = _repository.Table.Where(x => x.MatchId == matchId && x.TargetId == x.TargetId).FirstOrDefault();
            performanceMatchTarget.OrganizationId = organizationId;
            _repository.Update(performanceMatchTarget);
            _iEfPerformanceTargetResultDal.EditOrganizationId(performanceMatchTarget.Id, organizationId);
        }

        public List<PerformancePeriotMatchTagetCartDto> ListPerformancePeriotMatchTargetCartSingle(int targetId)
        {
            var performansPeriotList = (from PP in 
                                            
                                            _context.Performance_Target_Results.Where(x=>x.TargetId==targetId).GroupBy(x=> new {x.TargetTime.Year,x.TargetId,x.PerformanceId,x.PerformanceMatchId }).Select(x=>new PerformanPeriotGroupDto {Year=x.Key.Year, TargetId=x.Key.TargetId,PerformanceId=x.Key.PerformanceId,Target= x.Sum(s => s.Target), Result = x.Sum(s => s.Result) })
                                        
                                        join P in _context.Performances

                                             on PP.PerformanceId equals P.Id
                      
                                        select new PerformancePeriotMatchTagetCartDto()
                                        {
                                            PerformanceExplanation = P.Explanation,
                                            TargetYear = PP.Year,
                                            TargetPeriotMonth=P.PerformancePeriot.Explanation,
                                            //     P.PerformanceAim.Explanation,
                                            TargetValue = PP.Target,
                                            ResultValue = PP.Result
                                        }
                               ).ToList();
            return performansPeriotList;
        }

        public List<PerformancePeriotMatchDto> ListPerformancePeriotMatchTargetSingle(int Id)
        {
            var performansPeriotList = (from PP in _context.Performance_Target_Results
                                        where (PP.PerformanceMatchId == Id)
                                        join P in _context.Performances

                                             on PP.PerformanceId equals P.Id
                                        /*   join PA in _context.PerformanceAims
                                                on P.PerformanceAimId equals PA.Id*/
                                        join PM in _context.PerformanceMatchTargets

                                        on PP.PerformanceMatchId equals PM.Id

                                        join T in (_context.Targets)
                                      on PM.TargetId equals T.Id
                                        where (PM.Id == Id)
                                        /* join M in (_context.Matchs)
                                             on PM.MatchId equals M.Id
                                         where M.Explanation == "Hedef"
                                        */
                                        select new PerformancePeriotMatchDto()
                                        {
                                            Id = PP.Id,

                                            PerformanceExplanation = P.Explanation,
                                            AimExplanation = T.Explanation,
                                            ResultExplanation = PP.Explanation,
                                            TargetTime = PP.TargetTime,

                                            //     P.PerformanceAim.Explanation,
                                            TargetValue = PP.Target,
                                            ResultValue = PP.Result
                                        }
                               ).ToList();
            return performansPeriotList;
        }

        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotActionSingle(int performanceId)
        {
         
            var performansPeriotList = (from PP in _context.Performance_Target_Results
                                        where (PP.PerformanceMatchId == performanceId)
                                        join P in _context.Performances
                                             on PP.PerformanceId equals P.Id
                                        /*   join PA in _context.PerformanceAims
                                                on P.PerformanceAimId equals PA.Id*/
                                        join PM in _context.PerformanceMatchTargets
                                       on PP.PerformanceMatchId equals PM.Id

                                        join A in (_context.Actions)
                                            on PM.TargetId equals A.Id
                                        where (PM.Id == performanceId)
                                    /*    join M in (_context.Matchs)
                                            on PM.MatchId equals M.Id
                                     
                                        /*   where M.Explanation == "Faaliyet" &&
                                           */
                                        select new PerformancePeriotMatchDto()
                                        {
                                            Id = PP.Id,

                                            PerformanceExplanation = P.Explanation,
                                            AimExplanation = A.Explanation,
                                            ResultExplanation = PP.Explanation,
                                            TargetTime = PP.TargetTime,

                                            //     P.PerformanceAim.Explanation,
                                            TargetValue = PP.Target,
                                            ResultValue = PP.Result
                                        }
                         ).ToList();
            return performansPeriotList;
        }

        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotSubActionSingle(int performanceId)
        {

            var performansPeriotList = (from PP in _context.Performance_Target_Results
                                        where (PP.PerformanceMatchId == performanceId)
                                        join P in _context.Performances
                                             on PP.PerformanceId equals P.Id
                                        /*   join PA in _context.PerformanceAims
                                                on P.PerformanceAimId equals PA.Id*/
                                        join PM in _context.PerformanceMatchTargets
                                             on PP.PerformanceMatchId equals PM.Id


                                        join SA in (_context.SubActions)
                                    on PM.TargetId equals SA.Id
                                        where (PM.Id == performanceId)
                                        /* join M in (_context.Matchs)
                                             on PM.MatchId equals M.Id
                                         where M.Explanation == "Alt Faaliyet"*/

                                        select new PerformancePeriotMatchDto()
                                        {
                                            Id = PP.Id,

                                            PerformanceExplanation = P.Explanation,
                                            AimExplanation = SA.Explanation,
                                            ResultExplanation=PP.Explanation,
                                            TargetTime = PP.TargetTime,

                                            //     P.PerformanceAim.Explanation,
                                            TargetValue = PP.Target,
                                            ResultValue = PP.Result
                                        }
                  ).ToList();
            return performansPeriotList;
        }

        public void DeletePerformanceMatch(int Id)
        {
            var performanMatch = _repository.GetById(Id);
            _repository.Delete(performanMatch);
        }
    }
}
