using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfActionDal : IEfActionDal
    {
        private readonly IRepository<DAL.Model.Action> _repository;
        public EfActionDal(IRepository<DAL.Model.Action> repository)
        {
            _repository = repository;
        }

        public void AddAction(DAL.Model.Action action)
        {
            _repository.Insert(action);
        }

        public List<DAL.Model.Action> ActionList(int targetId)
        {
            var ActionList=_repository.Table.Where(x => x.TargetId == targetId).ToList();
            return ActionList;
        }

        public void EditTarget(int id, int targetId)
        {
            var action = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            if (action != null)
            {
                action.TargetId = targetId;
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }

        }

        public void EditAction(int id, int targetId, string explanation)
        {
            var action = _repository.Table.Where(x => x.Id == id).FirstOrDefault();

            if (action != null)
            {
                action.TargetId = targetId;
                action.Explanation = explanation;
            }
            else
            {
                throw new Exception("Not Found SubAction");
            }
        }

        public List<DAL.Model.Action> ActionListFull()
        {
            var ActionList = _repository.Table.ToList();
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
    }
}
