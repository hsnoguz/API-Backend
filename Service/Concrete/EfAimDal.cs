using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfAimDal : IEfAimDal
    {
        private readonly IRepository<Aim> _repository;
        private readonly IEfTargetDal _efTargetDal;
        private readonly IEfActionDal _efActionDal;
        private readonly IEfSubActionDal _efSubActionDal;

        public EfAimDal(IRepository<Aim> repository, IEfTargetDal efTargetDal, IEfActionDal efActionDal, IEfSubActionDal efSubActionDal)
        {
            _repository = repository;
            _efTargetDal = efTargetDal;
            _efActionDal = efActionDal;
            _efSubActionDal = efSubActionDal;
        }

        public void AddAim(Aim aim)
        {
            _repository.Insert(aim);
        }

        public List<Aim> AimList(int periotId)
        {
            var aimList=_repository.Table.Where(x => x.PeriotId == periotId).ToList();
            return aimList;
        }


        public void EditAim(int id,  string explanation)
        {
            var aim = _repository.Table.Where(x => x.Id == id).FirstOrDefault();

            if (aim != null)
            {
                aim.Explanation = explanation;
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }
        }
        public void DeleteAim( int id)
        {
            var aim = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (aim != null)
            {
                _repository.Delete(aim);
            }
            else
            {
                throw new Exception("Not Found Aim");
            }



            
        }

        public List<Aim> FullPlan(int periotId)
        {
            var aimList = _repository.Table.Where(x => x.PeriotId == periotId).ToList();
           
            foreach (Aim aim in aimList)
            {
                Aim _aim = aim;
                setTarget(ref _aim);
              
            }
            return aimList;
        }

        public void setTarget(ref Aim aim)
        {
            aim.Targets = _efTargetDal.TargetList(aim.Id);
            foreach (var target in aim.Targets)
            {
                Target _target = target;
                setAction(ref _target);
            }
        }
        public void setAction(ref Target target)
        {

            target.Actions = _efActionDal.ActionList(target.Id);
            foreach (var action in target.Actions)
            {
                DAL.Model.Action _action = action;
                setSubAction(ref _action);
            }
        }

        public void setSubAction(ref DAL.Model.Action action)
        {
            action.SubActions = _efSubActionDal.SubActionList(action.Id);
        }
    }
   
}
