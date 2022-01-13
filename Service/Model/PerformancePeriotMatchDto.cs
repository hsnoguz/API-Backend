using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class PerformancePeriotMatchDto
    {
        public int Id { get; set; }
        public string PerformanceExplanation { get; set; }
        public string AimExplanation { get; set; }
        public string ResultExplanation { get; set; }
        public DateTime TargetTime { get; set; }
        public decimal ResultValue { get; set; }
        public decimal TargetValue { get; set; }

    }
}
