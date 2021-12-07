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
    public class ActionManager : IActionManager
    {
        private readonly IEfActionDal _efActionDal;
        public ActionManager(IEfActionDal efActionDal)
        {
            _efActionDal = efActionDal;
        }
        public IResult AddAction(DAL.Model.Action Action)
        {
            IResult result;
            try
            {
                _efActionDal.AddAction( Action);
                result= new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;
            
        }

        public IResult EditTarget(int id, int targetId)
        {
            IResult result;
            try
            {
                _efActionDal.EditTarget(id,targetId);
                result = new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;

        }

        public IResult EditAction(DAL.Model.Action action)
        {
            IResult result;
            try
            {
                _efActionDal.EditAction(action);
                result = new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;

        }

        public List<DAL.Model.Action> ActionListFull()
        {
            return _efActionDal.ActionListFull();
        }

        public List<DAL.Model.Action> ActionList(int targetId)
        {
            return _efActionDal.ActionList(targetId);
        }

        public IResult DeleteAction( int id)
        {
            try
            {
                _efActionDal.DeleteAction(id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResultData<int> GetOrganizationId(int actionId)
        {
            return new SuccessResultData<int>( _efActionDal.GetOrganizationId(actionId));
        }
    }
}
