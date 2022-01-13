using Core.Entities.Concrete;
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
        public int TargetId { get; set; }
        public int PerformanceMatchId { get; set; }
        public decimal Target { get; set; }
        public decimal Result { get; set; }
        public string Explanation { get; set; }
        public int OrganizationId { get; set; }
        public bool IsEntry{ get; set; }
        public bool IsManual { get; set; }
        public DateTime TargetTime { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual Organization Organization { get; set; }
   
    }
}
