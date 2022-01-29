using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class PerformanPeriotGroupDto:ICustomEntity
    {
        public int PerformanceId { get; set; }
        public int TargetId { get; set; }
        public int Year { get; set; }
        public int PerformanceMatchId { get; set; }
        public decimal? Target { get; set; }
        public decimal? Result { get; set; }
    }
}
