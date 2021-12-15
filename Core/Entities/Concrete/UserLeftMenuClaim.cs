using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public partial class UserLeftMenuClaim : IEntity
    {
        public int Id { get; set; }
        public int OperationClaimId { get; set; }
        public int LeftMenuId { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
 
    }
}
