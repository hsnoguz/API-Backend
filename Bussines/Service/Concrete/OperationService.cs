using Bussines.Service.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public class OperationService : IOperationService
    {
        IEfOperationServiceDal _operationClaim;
        public OperationService(IEfOperationServiceDal operationClaim)
        {
            _operationClaim = operationClaim;
        }
        public int RoleId(string roleName)
        {
           return _operationClaim.RoleId(roleName);
        }

        public IResultData<List<OperationClaim>> RoleList()
        {
            return new SuccessResultData<List<OperationClaim>>(_operationClaim.RoleList());
        }
    }
}
