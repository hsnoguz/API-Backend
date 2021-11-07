using Bussines.Abstract;
using Bussines.Concrete;
using Bussines.Service.Abstract;
using Core.Entities.Concrete;
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
    public class OrganizationService :  IOrganizationService
    {
      /*  IEfListServiceDal<Organization> _efListService;
        public OrganizationService(IEfListServiceDal<Organization> efListService):base(efListService)
        {
            _efListService = efListService;
        }*/

        IEfOrganizationServiceDal _organization;

        public OrganizationService(IEfOrganizationServiceDal organization)
        {
            _organization = organization;
        }
        public List<Organization> OrganizationList()
        {
            return _organization.OrganizationList();
        }
        public IResultData<Organization> getEntity(int organizationId)
        {
            return new SuccessResultData<Organization>(_organization.GetEntity(organizationId));
        }

        public List<int> OrganizationDalList(int organizationId)
        {
            return _organization.OrganizationDalList(organizationId);
        }
    }


}
