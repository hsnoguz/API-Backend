using Bussines.Abstract;
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
   public class SignTypeManager:ListService<PerformanceType>, ISignTypeManager
    {
        IEfListServiceDal<PerformanceType> _efListService;
    public SignTypeManager(IEfListServiceDal<PerformanceType> efListService) : base(efListService)
    {
        _efListService = efListService;
    }

        public IResult UpdateSignType(int id, string explanation)
        {
 
            PerformanceType _signType = this._efListService.Table.Where(x => x.Id == id).FirstOrDefault();
            _signType.Explanation = explanation;
            this.Update(_signType);
            return new SuccessResult();
        }
    }
}
