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
    public class ActionPriceManager : IActionPriceManager
    {
        IEfActionPriceDal _efActionPriceDal;
        IAuthService _authService;
        public ActionPriceManager(IEfActionPriceDal efActionMatchPriceDal, IAuthService authService)
        {
            _efActionPriceDal = efActionMatchPriceDal;
            _authService = authService;
        }

        public IResult DeleteActionPrice(int Id)
        {
            try
            {
                _efActionPriceDal.DeleteActionPrice(Id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult InsertActionPrice(ActionPrice actionMatchPrice)
        {
            try
            {
                _efActionPriceDal.InsertActionPrice(actionMatchPrice);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }


        public IResultData<List<ActionPriceMatchDto>> ListActionPrice(string roleName, int userId, int periotId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<ActionPriceMatchDto>>(_efActionPriceDal.ListActionPrice(roleId, organizationId, periotId));
        }

        public IResultData<List<ActionPriceMatchDto>> ListActionSubActionPrice(string roleName, int userId, int periotId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<ActionPriceMatchDto>>(_efActionPriceDal.ListActionPrice(roleId, organizationId, periotId));
        }

        public IResultData<List<ActionPriceMatchDto>> ListSubActionPrice(string roleName, int userId, int periotId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<ActionPriceMatchDto>>(_efActionPriceDal.ListActionPrice(roleId, organizationId, periotId));
        }

        public IResult SetActionPriceResult(int Id, decimal Result)
        {
            try
            {
                _efActionPriceDal.SetActionPriceResult(Id,Result);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}
