using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class LeftMenuClaimDto: ICustomEntity
    {
        public short Id { get; set; }
        public string Description { get; set; }
        public string Src { get; set; }
        public short? MenuId { get; set; }
        public short? MenuIndex { get; set; }
        public string OnClick { get; set; }
        public string ImageUrl { get; set; }
        public int ClaimId { get; set; }
        public string ClaimName { get; set; }
    }
}
