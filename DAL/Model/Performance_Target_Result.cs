using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public  class Performance_Target_Result
    {
        public int Id { get; set; }
        public int PerformanceId { get; set; }
        public decimal Target { get; set; }
        public decimal Result { get; set; }
        public string Explanation { get; set; }
        public DateTime TargetTime { get; set; }
        public DateTime? InsertTime { get; set; }

    }
}
