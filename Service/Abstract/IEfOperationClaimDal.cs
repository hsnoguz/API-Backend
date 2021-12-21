using Core.Entities.Concrete;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfOperationClaimDal
    {
        public List<OperationClaim> OperationClaimList();

        public void EditOperationClaim(OperationClaim operationClaim);

        public void AddOperationClaim(string name);
        public void DeleteOperationClaim(int id);
        
    }
}
