using DAL.Model;
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
    public class EfTargetDal : IEfTargetDal
    {
        private readonly IRepository<Target> _repository;
        ManagerContext _context;
        public EfTargetDal(IRepository<Target> repository, ManagerContext context)
        {
            _repository = repository;
            _context = context;
        }

        public void AddTarget(Target Target)
        {
            _repository.Insert(Target);
            setTargetId(Target);
        }

        public List<Target> TargetListFull(int periotId)
        {
            var TargetList =
                (                from T in _context.Targets
                                          
                                    join AP in _context.Aims
                                            on T.AimId equals AP.Id
                                    where AP.PeriotId == periotId
                                    select T
                              ).ToList();
            // _repository.Table.Where(x=>x.Aim.PeriotId==periotId).ToList();
            return TargetList;
        }

        public void setTargetId(Target target)
        {
            target.TargetId = target.AimId.ToString() + "." +   target.Id.ToString();
            _repository.Update(target);
        }

        public List<Target> TargetList(int aimId)
        {
            var TargetList=_repository.Table.Where(x => x.AimId == aimId).ToList();
            return TargetList;
        }


        public void EditAim(int id, int aimId)
        {
            var target = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (target != null)
            {
                target.AimId = aimId;
                
                _repository.Update(target);
                setTargetId(target);
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }

        }

        public void EditTarget(int id, int aimId, string explanation)
        {
            var target = _repository.Table.Where(x => x.Id == id).FirstOrDefault();

            if (target != null)
            {
                target.AimId = aimId;
                target.Explanation = explanation;
                _repository.Update(target);
                setTargetId(target);
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }
        }


        public void DeleteTarget( int id)
        {
            var Target = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (Target != null)
            {
                _repository.Delete(Target);
            }
            else
            {
                throw new Exception("Not Found Target");
            }
            
        }

        public int GetTargetAimId(int targetId)
        {
            return _repository.GetById(targetId).AimId;
        }

        public List<TargetDto> TargetAimList(int periotId)
        {
            var TargetList =
             (from T in _context.Targets

              join AP in _context.Aims
                         on T.AimId equals AP.Id
              where AP.PeriotId == periotId
              select new TargetDto()
              {
                  Id=T.Id,
                  TargetId=T.TargetId,
                  Explanation=T.Explanation,
                  AimExplanation=AP.Explanation
              }
                           ).ToList();
            // _repository.Table.Where(x=>x.Aim.PeriotId==periotId).ToList();
            return TargetList;

        }
    }
}
