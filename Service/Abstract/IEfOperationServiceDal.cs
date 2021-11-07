using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfOperationServiceDal
    {
        public int RoleId(string roleName);
        public List<OperationClaim> RoleList();
    }
}
