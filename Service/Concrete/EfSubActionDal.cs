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
    public class EfSubActionDal : IEfSubActionDal
    {
        private readonly IRepository<DAL.Model.SubAction> _repository;
        public EfSubActionDal(IRepository<DAL.Model.SubAction> repository)
        {
            _repository = repository;
        }

        public void AddSubAction(DAL.Model.SubAction SubAction)
        {
            _repository.Insert(SubAction);
        }

        public List<DAL.Model.SubAction> SubActionListFull()
        {
            var SubActionList = _repository.Table.ToList();
            return SubActionList;
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

        public void EditSubAction(int id, int actionId,string explanation)
        {
            var subAction = _repository.Table.Where(x => x.Id == id).FirstOrDefault();
            
            if (subAction != null)
            {
                subAction.ActionId = actionId;
                subAction.Explanation= explanation;
            }
            else
            {
                throw new Exception("Not Found SubAction");
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
    }
}
