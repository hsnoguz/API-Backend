using Core.Entities.Concrete;
using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
 public interface IOperationService
    {
        public int RoleId(string roleName);
        public IResultData<List<OperationClaim>> RoleList();
    }
}
