
using Core.Entities.Concrete;
using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public  class EfOrganizationServiceDal: IEfOrganizationServiceDal
    {
        IRepository<Organization> _organization;
        List<int> dalOrganizationId = new List<int>();
        public EfOrganizationServiceDal(IRepository<Organization> organization)
        {
            _organization = organization;
            dalOrganizationId = new List<int>();
        }

        public List<int> OrganizationDalList(int organizationId,bool firstFor=true)
        {
            if (firstFor) { dalOrganizationId = new(); dalOrganizationId.Add(organizationId); }
            var temporganizationList=_organization.Table.Where(x => x.ParentId == organizationId).ToList();
            if (temporganizationList != null)
            {
                foreach (var item in temporganizationList)
                {
                    dalOrganizationId.Add(item.Id);
                    OrganizationDalList(item.Id,false);
                }
            }
            
            return dalOrganizationId;
        }
        public Organization GetEntity(int organizationId)
        {
            return _organization.GetById(organizationId);
        }
        public List<Organization> OrganizationList()
        {
           return _organization.Table.ToList();
        }
    }
}
