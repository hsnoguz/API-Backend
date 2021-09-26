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
    public class AimManager : IAimManager
    {
        private readonly IEfAimDal _efAimDal;
        public AimManager(IEfAimDal efAimDal)
        {
            _efAimDal = efAimDal;
        }
        public IResult AddAim( Aim aim)
        {
            IResult result;
            try
            {
                _efAimDal.AddAim( aim);
                result= new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;
            
        }

        public List<Aim> AimList(int periotId)
        {
            return _efAimDal.AimList(periotId);
        }

        public IResult DeleteAim( int id)
        {
            try
            {
                _efAimDal.DeleteAim(id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
    }
}
