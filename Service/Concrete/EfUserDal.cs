
using DAL.Abstract;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using Microsoft.Extensions.Configuration;

using System.IdentityModel.Tokens.Jwt;

using System.Security.Claims;
using Service.Abstract;

namespace Service.Concrete
{
    public class EfUserDal :Repository<User>,IUserDal //<T> where T : class, IUserDal<T> 
    {
        ManagerContext _context;

        
        public EfUserDal(ManagerContext context) :base(context)
        {
            _context = context;
      
        }
        public List<OperationClaim> GetClaims(int userId)
        {

            //var result = this.Table.Include(x => x.UserOperationClaim).Include(x=>x.UserOperationClaim.UserId).Where(x=>x.UserId==user.Id).Select(x=>new OperationClaim { Id=x.OperationClaimId,Name=x.OperationClaim.Name});
            /*from operationClaim in context.OperationClaims
                            join userOperationClaim in context.UserOperationClaims
                                on operationClaim.Id equals userOperationClaim.OperationClaimId
                            where userOperationClaim.UserId == user.Id
                            select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };*/
            //   return result.ToList();
            List<OperationClaim> operations = new();
            var resultUser = this.Table.Include(x => x.UserOperationClaim).ThenInclude(x=>x.OperationClaim).Where(x => x.Id == userId).ToList();
            foreach (var resultUserOperation in resultUser)
            {

                foreach (var operation in resultUserOperation.UserOperationClaim)
                {
                    operations.Add(operation.OperationClaim);
                }

                /*   if (resultUserOperation.UserOperationClaim.Count == 0)
                   { 

                   }
                   foreach (var operation in resultUserOperation.UserOperationClaim)
                   {
                       operations.AddRange(operation.OperationClaims);
                   }*/

            }
            return operations;
         
        }

        public void SetRefreshToken(int userId, int refreshTokenId)
        {
            var user = this.Table.Where(x => x.Id == userId).FirstOrDefault();
            user.RefreshTokenId = refreshTokenId;
            this.Update(user);
        }

        public int currentUserOrgizationId(int userId)
        {
            var Id = this.Table.Where(x => x.Id == userId).Select(c => c.OrganizationId).FirstOrDefault();
            return Id;
        }
    }
}
