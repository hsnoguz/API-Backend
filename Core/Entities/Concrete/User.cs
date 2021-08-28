using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int OrganizationId { get; set; }
        public int BranchId { get; set; }

        public int JopId { get; set; }
        public string IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenEndDate { get; set; }
        public DateTime InsertTime { get; set; }
        public virtual List<UserOperationClaim> UserOperationClaim { get; set; }
        public virtual Jop Jop { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
