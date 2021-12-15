using Bussines.Abstract;
using Core.Results;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class UserLeftMenuClaimManager : IUserLeftMenuClaim
    {
        IEfUserLeftMenuClaimDal _efUserLeftMenuClaimDal;
        public UserLeftMenuClaimManager(IEfUserLeftMenuClaimDal efUserLeftMenuClaimDal)
        {
            _efUserLeftMenuClaimDal = efUserLeftMenuClaimDal;
        }
        public IResult AddUserLeftMenuClaim(int roleId, int leftMenuId)
        {
            try
            {
                _efUserLeftMenuClaimDal.AddUserLeftMenuClaim(roleId,leftMenuId);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult DeleteUserLeftMenuClaim(int Id)
        {
            try
            {
                _efUserLeftMenuClaimDal.DeleteUserLeftMenuClaim(Id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResultData<List<UserLeftMenuClaimDto>> ListUserLeftMenuClaim()
        {
            var result = _efUserLeftMenuClaimDal.ListUserLeftMenuClaim();
            return new SuccessResultData<List<UserLeftMenuClaimDto>>(result);
        }
    }
}
