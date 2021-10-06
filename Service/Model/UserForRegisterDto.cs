using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class UserForRegisterDto : ICustomEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BranchId { get; set; }
        public int JopId { get; set; }
        public int OrganizationId { get; set; }

    }
}
