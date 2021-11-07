using Bussines.Service.Abstract;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public class UserOperationClaim : IUserOperationClaim
    {
        IEfUserOperationClaimDal _efUserOperationClaimDal;
        public UserOperationClaim(IEfUserOperationClaimDal efUserOperationClaimDal)
        {
            _efUserOperationClaimDal = efUserOperationClaimDal;
        }
        public void AddOperatiomClaim(int userId, int roleId)
        {
            _efUserOperationClaimDal.AddOperatiomClaim(userId,roleId);
        }
    }
}
