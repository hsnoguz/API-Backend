using Core.Entities.Concrete;
using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IOperationClaimManager
    {
        public IResultData<List<OperationClaim>> OperationClaimList();
        public IResult EditOperationClaim(OperationClaim operationClaim);
        public IResult AddOperationClaim(string name);
        public IResult DeleteOperationClaim(int id);


    }
}
