using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
   public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Telephone { get; set; }
        public string Email { get; set; }
        public Int16[] SubeID { get; set; }
        public string IsActive { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
