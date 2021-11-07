using Core.Entities.Concrete;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfOrganizationServiceDal
    {
        public List<Organization> OrganizationList();
        public Organization GetEntity(int organizationId);
        public List<int> OrganizationDalList(int organizationId, bool firstFor = true);
    }
}
