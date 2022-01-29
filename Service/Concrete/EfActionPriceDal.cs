using DAL.Model;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfActionPriceDal : IEfActionPriceDal
    {
        public IRepository<ActionPrice> _repository;
        ManagerContext _context;
        IEfOperationServiceDal _efOperationServiceDal;
        IEfOrganizationServiceDal _efOrganizationServiceDal;
        public EfActionPriceDal(IRepository<ActionPrice> repository, ManagerContext context, IEfOperationServiceDal efOperationServiceDal, IEfOrganizationServiceDal efOrganizationServiceDal)
        {
            _repository = repository;
            _context = context;
            _efOperationServiceDal = efOperationServiceDal;
            _efOrganizationServiceDal=efOrganizationServiceDal;
        }
        public void InsertActionPrice(ActionPrice actionMatchPrice)
        {
            _repository.Insert(actionMatchPrice);
        }

        public void EditActionPrice(EditActionPriceMatchDto actionMatchPrice)
        {
            var _actionPrice = _repository.GetById(actionMatchPrice.Id);
            _actionPrice.TargetValue = actionMatchPrice.TargetValue;
            _actionPrice.ResultValue= actionMatchPrice.ResultValue;

            _repository.Update(_actionPrice);
        }

        public List<ActionPriceMatchDto> ListActionSubActionPrice(int roleId, int organizationId, int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);

            List<ActionPriceMatchDto> matchList = (from PM in _context.ActionPrices
                                                   where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id

                                                   join A in _context.Actions.DefaultIfEmpty()
                                                        on new { Id = PM.ActionId, key2 = M.Explanation }
                                                        equals
                                                        new { Id = A.Id, key2 = "Faaliyet" }
                                                         into resut2
                                                   from resultFa in resut2.DefaultIfEmpty()

                                                   join T in _context.Targets.DefaultIfEmpty()
                                                           on resultFa.TargetId
                                                           equals
                                                           T.Id
                                                            into resutActionTarget
                                                   from resultAcFa in resutActionTarget.DefaultIfEmpty()
                                                   join Am in _context.Aims.DefaultIfEmpty()
                                                            on resultAcFa.AimId
                                                            equals
                                                            Am.Id
                                                                into resutActionTargetAim
                                                   from resultAcFaAm in resutActionTargetAim.DefaultIfEmpty()

                                                   select new ActionPriceMatchDto()
                                                   {
                                                       Id = PM.Id,
                                                       MatchExplanation = M.Explanation,
                                                       AimExplanation =resultAcFaAm.Explanation,
                                                       TargetExplanation=resultAcFa.Explanation,
                                       
                                                       ActionExplanation = resultFa.Explanation,
                                                       //SubActionExplanation = resultAFa.Explanation,

                                                       TargetValue = PM.TargetValue,
                                                       ResultValue = PM.ResultValue
                                                   }
                                                  ).ToList();
                              List<ActionPriceMatchDto> matchSubActionList = (from PM in _context.ActionPrices
                                                   where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id

                                                        join SA in _context.SubActions.DefaultIfEmpty()
                                                                            on new { Id = PM.ActionId, key2 = M.Explanation }
                                                                            equals
                                                                            new { Id = SA.Id, key2 = "Alt Faaliyet" }
                                                                                    into resut3
                                                        from resultAFa in resut3.DefaultIfEmpty()
                                                        join A in _context.Actions.DefaultIfEmpty()
                                                                                on resultAFa.ActionId   
                                                                                equals
                                                                              A.Id
                                                             into resut4
                                                            from resultFa in resut4.DefaultIfEmpty()

                                                            join T in _context.Targets.DefaultIfEmpty()
                                                           on resultFa.TargetId
                                                           equals
                                                           T.Id
                                                            into resutActionTarget
                                                   from resultAcFa in resutActionTarget.DefaultIfEmpty()
                                                   join Am in _context.Aims.DefaultIfEmpty()
                                                            on resultAcFa.AimId
                                                            equals
                                                            Am.Id
                                                                into resutActionTargetAim
                                                   from resultAcFaAm in resutActionTargetAim.DefaultIfEmpty()

                                                   select new ActionPriceMatchDto()
                                                   {
                                                       Id = PM.Id,


                                                       MatchExplanation = M.Explanation,
                                                       
                                                       AimExplanation = resultAcFaAm.Explanation,
                                                       TargetExplanation = resultAcFa.Explanation,
                                                       ActionExplanation = resultFa.Explanation,
                                                       SubActionExplanation = resultAFa.Explanation,

                                                       TargetValue = PM.TargetValue,
                                                       ResultValue = PM.ResultValue
                                                   }
                                                  ).ToList();

            var resultList = matchList.Union(matchSubActionList).ToList();


            return resultList;
        }

        public List<ActionPriceMatchDto> ListActionPrice(int roleId, int organizationId, int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);

            List<ActionPriceMatchDto> matchList = (from PM in _context.ActionPrices
                                                   where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id

                                                   join A in _context.Actions.DefaultIfEmpty()
                                                        on new { Id = PM.ActionId, key2 = M.Explanation }
                                                        equals
                                                        new { Id = A.Id, key2 = "Faaliyet" }
                                                         into resut2
                                                   from resultFa in resut2.DefaultIfEmpty()
                                                  
                          

                                                   select new ActionPriceMatchDto()
                                                   {
                                                       Id = PM.Id,
                                             

                                                       MatchExplanation = M.Explanation,

                                                       ActionExplanation = resultFa.Explanation,
                                    
                                                       TargetValue = PM.TargetValue,
                                                       ResultValue= PM.ResultValue
                                                   }
                                                  ).ToList();
            return matchList;
        }

        public List<ActionPriceMatchDto> ListSubActionPrice(int roleId, int organizationId, int periotId)
        {
            int AdminRoleId = _efOperationServiceDal.RoleId("Admin");
            List<int> organizationIdList = new();
            organizationIdList = _efOrganizationServiceDal.OrganizationDalList(organizationId);

            List<ActionPriceMatchDto> matchList = (from PM in _context.ActionPrices
                                                   where ((roleId == AdminRoleId || organizationIdList.Contains(organizationId)) && PM.PeriotId == periotId)
                                                   join M in _context.Matchs on PM.MatchId equals M.Id

                                                   join SA in _context.SubActions.DefaultIfEmpty()
                                                        on new { Id = PM.ActionId, key2 = M.Explanation }
                                                        equals
                                                        new { Id = SA.Id, key2 = "Alt Faaliyet" }
                                                              into resut3
                                                   from resultAFa in resut3.DefaultIfEmpty()
                                        

                                                   select new ActionPriceMatchDto()
                                                   {
                                                       Id = PM.Id,
                                      

                                                       MatchExplanation = M.Explanation,

                                                       SubActionExplanation = resultAFa.Explanation,

                                                       TargetValue = PM.TargetValue,
                                                       ResultValue = PM.ResultValue
                                                   }
                                                  ).ToList();
            return matchList;
        }

        public void SetActionPriceResult(int Id, decimal Result)
        {
            var actionPrice = _repository.GetById(Id);
            actionPrice.ResultValue = Result;
            _repository.Update(actionPrice);
        }

        public void DeleteActionPrice(int Id)
        {
            var actionPrice = _repository.GetById(Id);
            _repository.Delete(actionPrice);
        }

  
    }
}
