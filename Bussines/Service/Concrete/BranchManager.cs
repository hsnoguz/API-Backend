using Bussines.Abstract;
using Bussines.Concrete;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Service.Abstract;
using Core.Entities.Concrete;

namespace Bussines.Service.Concrete
{
    public class BranchService :ListService<Branch>, IBranchService
    {
        IEfListServiceDal<Branch> _efListService;
        public BranchService(IEfListServiceDal<Branch> efListService):base(efListService)
        {
            _efListService = efListService;
        }
 
    }


}
