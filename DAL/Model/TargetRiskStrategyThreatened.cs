using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TargetRiskStrategyThreatenedNeed
    {
        public int Id { get; set; }
        public int TargetId { get; set; }
        public string Risk { get; set; }
        public string Strategy { get; set; }
        public string Threatened { get; set; }
        public string Need { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual Target Target{ get; set; }
    }
}
