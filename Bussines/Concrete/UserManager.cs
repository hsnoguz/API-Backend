using Bussines.Abstract;
using Bussines.Service.Abstract;
using Core.Entities.Concrete;
using Core.Extensions;
using Core.Results;
using DAL.Abstract;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IJopService _jopService;
        IBranchService _branchService;
        IOrganizationService _organizationService;


        public UserManager(IUserDal userDal,
            IJopService jopService,
            IOrganizationService organizationService,
            IBranchService branchService
            )
        {
            _userDal = userDal;
            _organizationService = organizationService;
            _branchService = branchService;
            _jopService = jopService;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Insert(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Table.FirstOrDefault(u => u.Email == email);
        }

        public IResultData<List<UserList>> GetUserList()
        {
            var userTable= _userDal.Table;
            var userList = userTable.Select(X => new UserList() { Id = X.Id, UserName = X.UserName, FirstName = X.FirstName, LastName = X.LastName, Email = X.Email, IsActive = X.IsActive, Telephone = X.Telephone, UserOperationClaim = X.UserOperationClaim }).ToList();
            foreach (var user in userList)
            {
                var tempUser = userTable.Where(x => x.Id == user.Id).FirstOrDefault();
                user.Jop = _jopService.getEntity(tempUser.JopId).Data;
                user.Branch = _branchService.getEntity(tempUser.BranchId).Data;
                user.Organization = _organizationService.getEntity(tempUser.OrganizationId).Data;


            }
            return new SuccessResultData<List<UserList>>(userList);
        }
    }
}
