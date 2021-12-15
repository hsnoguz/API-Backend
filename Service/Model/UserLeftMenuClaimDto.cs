using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
   public class UserLeftMenuClaimDto: ICustomEntity
    {
        public int Id { get; set; }
        public string LeftMenuDescription { get; set; }
        public string ClaimName { get; set; }

    }
}
