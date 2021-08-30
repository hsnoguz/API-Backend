using Bussines.Service.Abstract;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public class RefreshTokenService : IRefreshTokenService
    {
        IEfRefreshTokenDal _refreshTokenDal;
        public RefreshTokenService(IEfRefreshTokenDal refreshTokenDal)
        {
            _refreshTokenDal = refreshTokenDal;
        }
        public bool getRefreshTokenControl(int userId, string token)
        {
          return  _refreshTokenDal.GetRefreshTokenControl(userId, token);
        }

        public int Insert(int userId, string newToken)
        {
           return _refreshTokenDal.Insert(userId, newToken);
        }
    }
}
