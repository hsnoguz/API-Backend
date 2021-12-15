using Core.Results;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IUserLeftMenuClaim
    {
        public IResultData<List<UserLeftMenuClaimDto>> ListUserLeftMenuClaim();
        public IResult AddUserLeftMenuClaim(int roleId, int leftMenuId);
        public IResult DeleteUserLeftMenuClaim(int Id);
    }
}
