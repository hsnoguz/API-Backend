using Core.Entities.Concrete;
using DAL.Model;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfUserLeftMenuClaimDal : IEfUserLeftMenuClaimDal
    {
        public IRepository<UserLeftMenuClaim> _repository;
        ManagerContext _context;
        public EfUserLeftMenuClaimDal(IRepository<UserLeftMenuClaim> repository, ManagerContext context)
        {
            _repository = repository;
            _context = context;
        }
        public void AddUserLeftMenuClaim(int roleId, int leftMenuId)
        {
            UserLeftMenuClaim userLeftMenuClaim = new UserLeftMenuClaim();
            userLeftMenuClaim.LeftMenuId = leftMenuId;
            userLeftMenuClaim.OperationClaimId = roleId;
            _repository.Insert(userLeftMenuClaim);
        }

        public void DeleteUserLeftMenuClaim(int Id)
        {
            UserLeftMenuClaim userLeftMenuClaim = _repository.GetById(Id);
            _repository.Delete(userLeftMenuClaim);
        }   

        public List<UserLeftMenuClaimDto> ListUserLeftMenuClaim()
        {
            return (from leftMenuClaim in _context.UserLeftMenuClaims
                    join leftMenu in _context.LeftMenus
                    on leftMenuClaim.LeftMenuId equals leftMenu.Id
                    where leftMenu.isActive == true

                    select new UserLeftMenuClaimDto()
                    {
                        Id = leftMenuClaim.Id,
                        ClaimName = leftMenuClaim.OperationClaim.Name,
                        LeftMenuDescription = leftMenu.Description
                    }
                   ).ToList();
        }
    }
}
