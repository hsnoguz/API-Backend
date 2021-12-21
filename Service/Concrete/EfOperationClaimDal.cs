using Core.Entities.Concrete;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfOperationClaimDal : IEfOperationClaimDal
    {
        IRepository<OperationClaim> _repository;
        public EfOperationClaimDal(IRepository<OperationClaim> repository)
        {
            _repository = repository;
        }

        public void AddOperationClaim(string name)
        {
            OperationClaim operationClaim = new OperationClaim();
            operationClaim.Name = name;
            _repository.Insert(operationClaim);
        }

        public void DeleteOperationClaim(int id)
        {
            OperationClaim operationClaim = _repository.GetById(id);
            _repository.Delete(operationClaim);
        }

        public void EditOperationClaim(OperationClaim operationClaim)
        {
         
            _repository.Update(operationClaim);
        }

        public List<OperationClaim> OperationClaimList()
        {
          return  _repository.Table.ToList();
        }
    }
}
