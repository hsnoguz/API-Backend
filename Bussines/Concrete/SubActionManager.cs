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
    public class SubActionManager : ISubActionManager
    {
        private readonly IEfSubActionDal _efSubActionDal;
        public SubActionManager(IEfSubActionDal efSubActionDal)
        {
            _efSubActionDal = efSubActionDal;
        }
        public IResult AddSubAction(DAL.Model.SubAction SubAction)
        {
            IResult result;
            try
            {
                _efSubActionDal.AddSubAction( SubAction);
                result= new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;
            
        }

        public List<DAL.Model.SubAction> SubActionList(int actionId)
        {
            return _efSubActionDal.SubActionList(actionId);
        }

        public IResult DeleteSubAction( int id)
        {
            try
            {
                _efSubActionDal.DeleteSubAction(id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
    }
}
