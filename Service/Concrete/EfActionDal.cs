using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = DAL.Model.Action;

namespace Service.Concrete
{
    public class EfActionDal : IEfActionDal
    {
        private readonly IRepository<DAL.Model.Action> _repository;
        IEfTargetDal _efTargetDal;
        
        IEfPerformanceMatchTargetDal _efPerformanceMatchTargetDal;
        ManagerContext _context;
        public EfActionDal(IRepository<DAL.Model.Action> repository, ManagerContext context, IEfTargetDal efTargetDal, IEfPerformanceMatchTargetDal efPerformanceMatchTargetDal)
        {
            _repository = repository;
            _efTargetDal = efTargetDal;
            _efPerformanceMatchTargetDal = efPerformanceMatchTargetDal;
            _context= context;
        }

        public void AddAction(DAL.Model.Action action)
        {
            _repository.Insert(action);
            setActionId(action);
        }

        public List<DAL.Model.Action> ActionList(int targetId)
        {
            var ActionList=_repository.Table.Where(x => x.TargetId == targetId).ToList();
            return ActionList;
        }

        public List<ActionDto> ActionTargetAimList(int periotId)
        {

            var ActionList = (from A in _context.Actions
                              join T in _context.Targets
                                      on A.TargetId equals T.Id
                              join AP in _context.Aims
                                      on T.AimId equals AP.Id
                              join O in _context.Organizations
                                      on A.OrganizationId equals O.Id
                              where AP.PeriotId == periotId
                              select new ActionDto()
                              {
                                  Id = A.Id,
                                  ActionId = A.ActionId,
                                  Explanation = A.Explanation,
                                  TargetExplanation=T.Explanation,
                                  AimExplanation = AP.Explanation,
                                  OrganizationExplanation=O.Explanation
                              }
                           ).ToList();
            return ActionList;
        }


        public void setActionId(DAL.Model.Action action)
        {
            int aimId = GetActionAimId(action.TargetId);
            action.ActionId = aimId.ToString() + "." + action.TargetId.ToString() + "." + action.Id.ToString();
            _repository.Update(action);
        }

        public void EditTarget(int id, int targetId)
        {
            var action = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (action != null)
            {
                action.TargetId = targetId;
                _repository.Update(action);
                setActionId(action);
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }

        }

        public void EditAction(Action action)
        {
            var _action = _repository.Table.Where(x => x.Id == action.Id).FirstOrDefault();
            using (var transaction = _context.Database.BeginTransaction())
            {
                if (action != null)
                {
                    if (_action.OrganizationId != action.OrganizationId)
                    {
                        var MatchId= _efPerformanceMatchTargetDal.MatchList().Where(x => x.Explanation == "Faaliyet").Select(x=>x.Id).FirstOrDefault();
                        _efPerformanceMatchTargetDal.EditOrganizationId(MatchId, action.Id, action.OrganizationId);
                    }
                    _action.TargetId = action.TargetId;
                    _action.Explanation = action.Explanation;
                    _repository.Update(_action);
                    setActionId(_action);
                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                    throw new Exception("Not Found SubAction");
                }
            }
        }

        public List<DAL.Model.Action> ActionListFull(int periotId)
        {

            var ActionList = (from A in _context.Actions
                              join T in _context.Targets
                                      on A.TargetId equals T.Id
                              join AP in _context.Aims
                                      on T.AimId equals AP.Id
                                      where AP.PeriotId==periotId
                              select A
                              ).ToList();
            return ActionList;
        }

        public void DeleteAction( int id)
        {
            var Action = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (Action != null)
            {
                _repository.Delete(Action);
            }
            else
            {
                throw new Exception("Not Found Action");
            }

        }

        public int GetActionTargetId(int actionId)
        {
            return _repository.GetById(actionId).TargetId;
        }

        public int GetActionAimId(int targetId)
        {
            return _efTargetDal.GetTargetAimId(targetId);
        }

        public int GetOrganizationId(int actionId)
        {
            return _repository.GetById(actionId).OrganizationId;
        }
    }
}

