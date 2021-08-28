using Core.Entities.Concrete;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class UserList: ICustomEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        public DateTime InsertTime { get; set; }
        public virtual List<UserOperationClaim> UserOperationClaim { get; set; }
        public virtual DAL.Model.Jop Jop { get; set; }
        public virtual DAL.Model.Branch Branch { get; set; }
        public virtual DAL.Model.Organization Organization { get; set; }
    }
}
