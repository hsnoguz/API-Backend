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
    public class ManualPageManager : IManualPageManager
    {
        IEfManualPageDal _efManualPageDal;
        public ManualPageManager(IEfManualPageDal efManualPageDal)
        {
            _efManualPageDal = efManualPageDal;
        }
        public IResult DeleteManualPage(int Id)
        {
            try
            {
                _efManualPageDal.DeleteManualPage(Id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
        public IResult EditManualPage(ManualPage manaulPage)
        {
            try
            {
                _efManualPageDal.EditManualPage(manaulPage);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResultData<ManualPage> GetManualPage(int Id)
        {
            return new SuccessResultData<ManualPage>(_efManualPageDal.GetManualPage(Id));
        }

        public IResultData<int> InsertManualPage(ManualPage manaulPage)
        {
            try
            {
               int Id=  _efManualPageDal.InsertManualPage(manaulPage);
                return new SuccessResultData<int>(Id);
            }
            catch (Exception ex)
            {

                return new ErrorResultData<int>(0,ex.Message);
            }
        }
    }
}
