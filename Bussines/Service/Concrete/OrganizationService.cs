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
    public class OrganizationService : ListService<Organization>, IOrganizationService
    {
        IEfListServiceDal<Organization> _efListService;
        public OrganizationService(IEfListServiceDal<Organization> efListService):base(efListService)
        {
            _efListService = efListService;
        }
 
    }


}
