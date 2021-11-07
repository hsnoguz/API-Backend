
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
        List<OperationClaim> GetClaims(int userId);
        void SetRefreshToken(int userId,int refreshTokenId);
        public int currentUserOrgizationId(int userId);
    }
}
