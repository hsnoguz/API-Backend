using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public  class ActionPrice
    {
        public int Id { get; set; }
        public int PeriotId { get; set; }
        public int MatchId { get; set; }
        public int ActionId { get; set; }
        public decimal TargetValue { get; set; }
        public decimal ResultValue { get; set; }
        public DateTime? InsertTime { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Match Match { get; set; }
        public virtual Periot Periot { get; set; }
    }
}
