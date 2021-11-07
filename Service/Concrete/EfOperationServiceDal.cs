
using Core.Entities.Concrete;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfOperationServiceDal : IEfOperationServiceDal
    {
        IRepository<OperationClaim> _operationClaim;
        public EfOperationServiceDal(IRepository<OperationClaim> operationClaim)
        {
            _operationClaim = operationClaim;
        }
        public int RoleId(string roleName)
        {
           return _operationClaim.Table.Where(x => x.Name == roleName).Select(c=>c.Id).FirstOrDefault();
        }

        public List<OperationClaim> RoleList()
        {
            return _operationClaim.Table.ToList();
        }
    }
}
