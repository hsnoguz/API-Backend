using Bussines.Abstract;
using Bussines.BussinesAspects.Autofac;
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

    public class PeriotManager : IPeriotManager
    {
        IEfPeriotDal _efPeriotDal;
        public PeriotManager(IEfPeriotDal efPeriotDal)
        {
            _efPeriotDal = efPeriotDal;
        }

        [SecuredOperation("admin")]
   //     [ValidationAspect(typeof(BirimValidator))]
        public IResult createPeriot(string name, int startYear, int stopYear)
        {
            try
            {
                _efPeriotDal.createPeriot(name, startYear, stopYear);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
            return new SuccessResult();
        }

        [SecuredOperation("admin")]
        public IResult editPeriot(int id, string name)
        {
            try
            {
                _efPeriotDal.editPeriot(id,name);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
            return new SuccessResult();
        }

        public IResultData<List<Periot>> listPeriot()
        {
           
            return new SuccessResultData<List<Periot>>(_efPeriotDal.listPeriot());
        }

        public IResultData<Periot> currentPeriot(int Id)
        {
            return new SuccessResultData<Periot>(_efPeriotDal.currentPeriot(Id));
        }

    }
}
