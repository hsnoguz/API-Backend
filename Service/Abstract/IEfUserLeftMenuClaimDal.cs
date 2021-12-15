using Core.Entities.Concrete;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public  interface IEfUserLeftMenuClaimDal
    {
        public List<UserLeftMenuClaimDto> ListUserLeftMenuClaim();
        public void AddUserLeftMenuClaim(int roleId, int leftMenuId);
        public void DeleteUserLeftMenuClaim(int Id);

    }
} 
