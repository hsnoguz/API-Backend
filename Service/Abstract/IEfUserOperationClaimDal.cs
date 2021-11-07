using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfUserOperationClaimDal
    {
      
        public void AddOperatiomClaim(int userId,int roleId);
    }
}
