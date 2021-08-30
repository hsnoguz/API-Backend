using Core.Entities.Concrete;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public  interface IEfRefreshTokenDal
    {
        public bool GetRefreshTokenControl(int userId, string token);
        public int Insert(int userId, string newToken);
        public void UserAllRefreshTokenUsin(int userId);
    }
}
