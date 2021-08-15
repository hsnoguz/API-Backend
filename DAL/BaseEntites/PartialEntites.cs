using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BaseEntites
{
    class PartialEntites
    {
    }
    public partial class User : IEntity { }
    public partial class OperationClaim : IEntity { }
    public partial class UserOperationClaim : IEntity { }
}
