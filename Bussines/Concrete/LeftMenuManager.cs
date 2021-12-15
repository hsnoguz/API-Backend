using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
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

        public IResult AddLeftMenu(LeftMenu leftMenu)
        {
            try
            {
                _leftMenuDal.AddLeftMenu(leftMenu);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
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
