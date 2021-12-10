using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class ActionPriceMatchDto
    {
        public int Id { get; set; }
         public string MatchExplanation { get; set; }
         public string ActionExplanation { get; set; }
          public string SubActionExplanation { get; set; }
        public decimal TargetValue { get; set; }
        public decimal ResultValue { get; set; }

    }
}
