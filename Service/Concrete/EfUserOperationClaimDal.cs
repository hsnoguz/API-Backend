
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
    public class EfUserOperationClaimDal : IEfUserOperationClaimDal
    {
        IRepository<UserOperationClaim> _operationClaim;
        public EfUserOperationClaimDal(IRepository<UserOperationClaim> operationClaim)
        {
            _operationClaim = operationClaim;
        }

        public void AddOperatiomClaim(int userId, int roleId)
        {
            UserOperationClaim userOperationClaim = new UserOperationClaim();
            userOperationClaim.OperationClaimId = roleId;
            userOperationClaim.UserId = userId;
            _operationClaim.Insert(userOperationClaim);
        }
    }
}
