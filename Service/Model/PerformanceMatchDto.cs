using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class PerformanceMatchDto
    {
        public int Id { get; set; }
        public short PerformancePeriotExplanation { get; set; }
        public string PerformanceExplanation { get; set; }
         public string MatchExplanation { get; set; }
         public string TargetExplanation { get; set; }
        /* public string ActionExplanation { get; set; }
          public string SubActionExplanation { get; set; }*/
        public decimal BaseValue { get; set; }
        public decimal TargetValue { get; set; }

    }
}
