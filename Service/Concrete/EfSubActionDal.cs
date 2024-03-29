﻿using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfSubActionDal : IEfSubActionDal
    {
        private readonly IRepository<DAL.Model.SubAction> _repository;
        IEfActionDal _efActionDal;
        IEfPerformanceMatchTargetDal _efPerformanceMatchTargetDal;
        ManagerContext _context;
        public EfSubActionDal(IRepository<DAL.Model.SubAction> repository, ManagerContext context, IEfActionDal efActionDal, IEfPerformanceMatchTargetDal efPerformanceMatchTargetDal)
        {
            _repository = repository;
            _efActionDal = efActionDal;
            _context = context;
            _efPerformanceMatchTargetDal=efPerformanceMatchTargetDal;
    }

        public void AddSubAction(DAL.Model.SubAction SubAction)
        {
            _repository.Insert(SubAction);
            setSubActionId(SubAction);
        }

        public List<DAL.Model.SubAction> SubActionListFull(int periotId)
        {
            var SubActionList = (
                                    from S in _context.SubActions
                                    join A in _context.Actions
                                           on S.ActionId equals A.Id
                                    join T in _context.Targets
                                            on A.TargetId equals T.Id
                                    join AP in _context.Aims
                                            on T.AimId equals AP.Id
                                    where AP.PeriotId == periotId
                                    select S
                              ).ToList();

            //_repository.Table.Where(x=>x.Actionaa.Target.Aim.PeriotId==periotId).ToList();
            return SubActionList;
        }

        public List<SubActionDto> SubActionActionTargetAimListFull(int periotId)
        {
            var ActionList = (from S in _context.SubActions
                              join A in _context.Actions
                                     on S.ActionId equals A.Id
                              join T in _context.Targets
                                      on A.TargetId equals T.Id
                              join AP in _context.Aims
                                      on T.AimId equals AP.Id
                              join O in _context.Organizations
                                       on S.OrganizationId equals O.Id
                              where AP.PeriotId == periotId
                              select new SubActionDto()
                              {
                                  Id = S.Id,
                                  SubActionId = S.SubActionId,
                                  Explanation = S.Explanation,
                                  ActionExplanation = A.Explanation,
                                  TargetExplanation = T.Explanation,
                                  AimExplanation = AP.Explanation,
                                  OrganizationExplanation = O.Explanation
                              }
                           ).ToList();
            return ActionList;
        }

        public List<DAL.Model.SubAction> SubActionList(int actionId)
        {
            var SubActionList=_repository.Table.Where(x => x.ActionId == actionId).ToList();
            return SubActionList;
        }

        public void EditAction(int id, int newActionId)
        {
            var subAction = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (subAction != null)
            {
                subAction.ActionId = newActionId;
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }

        }

        public void EditSubAction(DAL.Model.SubAction subAction)
        {
            var _subAction = _repository.Table.Where(x => x.Id == subAction.Id).FirstOrDefault();
            bool organizationId = false;
            using (var transaction = _context.Database.BeginTransaction())
            {
                if (_subAction != null)
                {
                    if (_subAction.OrganizationId != subAction.OrganizationId)
                    {
                        var MatchId = _efPerformanceMatchTargetDal.MatchList().Where(x => x.Explanation == "Alt Faaliyet").Select(x => x.Id).FirstOrDefault();
                        _efPerformanceMatchTargetDal.EditOrganizationId(MatchId, subAction.Id, subAction.OrganizationId);
                    }
                    _subAction.ActionId = subAction.ActionId;
                    _subAction.Explanation = subAction.Explanation;

                    _repository.Update(_subAction);
                    setSubActionId(subAction);
                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                    throw new Exception("Not Found SubAction");
                }
            }
        }

        public void DeleteSubAction( int id)
        {
            var SubAction = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (SubAction != null)
            {
                _repository.Delete(SubAction);
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }

        }
        public void setSubActionId(DAL.Model.SubAction subAction)
        {
            int targetId = _efActionDal.GetActionTargetId(subAction.ActionId);
            int aimId = _efActionDal.GetActionAimId(targetId);
            subAction.SubActionId = aimId.ToString() + "." + targetId.ToString() + "." + subAction.ActionId.ToString() + "." +subAction.Id.ToString() ;
            _repository.Update(subAction);
        }

        public int GetOrganizationId(int subActionId)
        {
            return _repository.GetById(subActionId).OrganizationId;
        }

        public List<SubAction> ListFullPlan(int periotId)
        {
            /*  var SubActionList = (
                             from S in _context.SubActions
                             join A in _context.Actions
                                    on S.ActionId equals A.Id
                             join T in _context.Targets
                                     on A.TargetId equals T.Id
                             join AP in _context.Aims
                                     on T.AimId equals AP.Id
                             where AP.PeriotId == periotId
                             select S
                       ).ToList();
            */
            //var SubActionList = _repository.Table.Include(x=>x.Action).Include(x => x.Action.Target).Include(x => x.Action.Target.Aim).Where(x=>x.Action.Target.Aim.PeriotId==periotId).ToList();
            return new List<SubAction>();
       //     return SubActionList;
        }
    }
}
