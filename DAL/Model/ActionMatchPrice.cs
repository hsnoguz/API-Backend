using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public  class ActionMatchPrice
    {
        public int Id { get; set; }
        
        public Int16 MatchId { get; set; }
        public int ActionId { get; set; }

        public int OrganizationId { get; set; }
        public DateTime? InsertTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Performance Performance { get; set; }
    }
}
