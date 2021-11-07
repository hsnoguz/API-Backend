using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public  class PerformanceMatchTarget
    {
        public int Id { get; set; }
        public int PerformanceId { get; set; }
        public Int16 MatchId { get; set; }
        public int TargetId { get; set; }
        public int ActionId { get; set; }
        public int SubActionId { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual Performance GetPerformance { get; set; }
        public virtual Target Target{ get; set; }
        public virtual Action Action{ get; set; }
        public virtual SubAction SubAction{ get; set; }

    }
}
