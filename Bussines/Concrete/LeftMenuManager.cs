using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class LeftMenuManager : ILeftMenuManager
    {
        IEfLeftMenuDal _leftMenuDal;

        IEfActionPriceDal _efActionPriceDal;
        IAuthService _authService;

        public LeftMenuManager(IEfLeftMenuDal leftMenuDal, IEfActionPriceDal efActionMatchPriceDal, IAuthService authService)
        {
            _leftMenuDal = leftMenuDal;
            _efActionPriceDal = efActionMatchPriceDal;
            _authService = authService;
        }

        public IResultData<List<LeftMenuClaimDto>> GetLeftMenuFull() {
            return new SuccessResultData<List<LeftMenuClaimDto>>(_leftMenuDal.GetLeftMenuFull());
        }

        public IResultData<int> AddLeftMenu(LeftMenu leftMenu)
        {
            try
            {
                int Id=_leftMenuDal.AddLeftMenu(leftMenu);
                return new SuccessResultData<int>(Id);
            }
            catch (Exception ex)
            {

                return new ErrorResultData<int>(0,ex.Message);
            }
        }

        public IResult DeleteLeftMenu(int Id)
        {
            try
            {
                _leftMenuDal.DeleteLeftMenu(Id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResultData<List<LeftMenu>> GetLeftMenu(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<LeftMenu>>(_leftMenuDal.GetLeftMenu(roleId, userId));
        }
    }
}
