
using Core.Entities.Concrete;
using DAL.Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        void SetRefreshToken(int userId,string token,DateTime tokendatetime);

    }
}
