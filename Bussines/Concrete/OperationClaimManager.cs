using Bussines.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class OperationClaimManager : IOperationClaimManager
    {
        IEfOperationClaimDal _efOperationClaimDal;
        public OperationClaimManager(IEfOperationClaimDal efOperationClaimDal)
        {
            _efOperationClaimDal = efOperationClaimDal;
        }
        public IResult AddOperationClaim(string name)
        {
            try
            {
                _efOperationClaimDal.AddOperationClaim(name);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult();
            }
        }

        public IResult DeleteOperationClaim(int id)
        {
            try
            {
                _efOperationClaimDal.DeleteOperationClaim(id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult();
            }
        }

        public IResult EditOperationClaim(OperationClaim operationClaim)
        {
            try
            {
                _efOperationClaimDal.EditOperationClaim(operationClaim);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult();
            }
        }

        public IResultData<List<OperationClaim>> OperationClaimList()
        {
            return new SuccessResultData<List<OperationClaim>>(_efOperationClaimDal.OperationClaimList());
        }
    }
}
