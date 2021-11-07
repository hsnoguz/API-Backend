using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
    public interface IUserOperationClaim
    {
        public void AddOperatiomClaim(int userId, int roleId);

    }
}
