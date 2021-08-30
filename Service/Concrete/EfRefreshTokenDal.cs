
using Core.Entities.Concrete;

using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Core.Utilities.Security.JWT;

namespace Service.Concrete
{
    public class EfRefreshTokenDal: IEfRefreshTokenDal
    {

        IRepository<RefreshToken> _refreshToken;
        public IConfiguration Configuration { get; }
        public EfRefreshTokenDal(IRepository<RefreshToken> refreshToken, IConfiguration configuration) 
        {
            _refreshToken = refreshToken;
            Configuration = configuration;
        }

        public bool GetRefreshTokenControl(int userId, string token)
        {
            var row = _refreshToken.Table.Where(x => x.UserId == userId && x.IsUsing==false && x.Token == token && x.EndTime <= DateTime.Now);
            return row != null;
        }

        public int Insert(int userId, string newToken)
        {

            UserAllRefreshTokenUsin(userId);


            DateTime dateTime = DateTime.Now.AddMinutes(Configuration.GetSection("TokenOptions").Get<TokenOptions>().AccessTokenExpiration);
            var refreshToken = new RefreshToken();
            refreshToken.Token = newToken;
            refreshToken.UserId = userId;
            refreshToken.EndTime = dateTime;
            _refreshToken.Insert(refreshToken);
            return refreshToken.Id;
        }
        public void UserAllRefreshTokenUsin(int userId)
        {
            var res = _refreshToken.Table.Where(r => r.UserId == userId).ToList();
            // update
            foreach (var r in res)
            {
                r.IsUsing = true;
                _refreshToken.Update(r);
            }

        }
    }
}
