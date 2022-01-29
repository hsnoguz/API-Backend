using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class PerformancePeriotMatchTagetCartDto
    {
        
        public string PerformanceExplanation { get; set; }
        public int TargetPeriotMonth { get; set; }
        public int TargetYear { get; set; }
        public decimal? TargetValue { get; set; }
        public decimal? ResultValue { get; set; }


    }
}
