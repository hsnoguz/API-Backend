using Bussines.Concrete;
using Bussines.Service.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
  public class SignPeriotManager: ListService<SignPeriot>, ISignPeriot
    {
        IEfListServiceDal<SignPeriot> _efListService;
        public SignPeriotManager(IEfListServiceDal<SignPeriot> efListService) : base(efListService)
        {
            _efListService = efListService;
        }
        public IResult AddSignPeriot(SignPeriot signPeriot)
        {
            if (signPeriot.Explanation > 12)
            {
                return new ErrorResult( "Maksimum Value 12");
            }
         //   SignPeriot _signPeriot = new SignPeriot();
            this.Add(signPeriot);
            return new SuccessResult();
        }

        public IResult UpdateSignPeriot(int id,Int16 explanation)
        {
            if (Convert.ToInt16(explanation) > 12)
            {
                return new ErrorResult("Maksimum Value 12");
            }
            SignPeriot _signPeriot = this._efListService.Table.Where(x => x.Id == id).FirstOrDefault();
            _signPeriot.Explanation = explanation;
            this.Update(_signPeriot);
            return new SuccessResult();
        }
    }
}
