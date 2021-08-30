using Core.Entities.Concrete;
using Core.Results;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(int userId);
        void Add(User user);
        void SetRefreshTokenId(int userId,int refreshTokenId);
        User GetByMail(string email);
        User GetUser(int userId);
        IResultData<List<UserList>> GetUserList();
    }
}
