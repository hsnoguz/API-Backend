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
    public class TargetManager : ITargetManager
    {
        private readonly IEfTargetDal _efTargetDal;
        public TargetManager(IEfTargetDal efTargetDal)
        {
            _efTargetDal = efTargetDal;
        }
        public IResult AddTarget( Target Target)
        {
            IResult result;
            try
            {
                _efTargetDal.AddTarget( Target);
                result= new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;
            
        }

        public IResult EditAim(int id, int aimId) {
            IResult result;
            try
            {
                _efTargetDal.EditAim(id, aimId);
                result = new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;
        }
        public IResult EditTarget(int id, int aimId, string explanation)
        {
            IResult result;
            try
            {
                _efTargetDal.EditTarget(id, aimId, explanation);
                result = new SuccessResult();
            }
            catch (Exception ex)
            {

                result = new ErrorResult(ex.Message);
            }

            return result;
        }



        public List<Target> TargetListFull(int periotId)
        {
            return _efTargetDal.TargetListFull(periotId);
        }

        public List<Target> TargetList(int aimId)
        {
            return _efTargetDal.TargetList(aimId);
        }

        public IResult DeleteTarget( int id)
        {
            try
            {
                _efTargetDal.DeleteTarget(id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
    }
}
