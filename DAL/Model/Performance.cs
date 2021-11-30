using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
 public  class Performance
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public int PeriotId { get; set; }
        public int PerformancePeriotId { get; set; }
        public int PerformanceTypeId { get; set; }
        public int PerformanceAimId { get; set; } //Artış-Azalış-Aynı Seviye
      //  public int OrganizationId { get; set; } Sorumlu Birim
        public int StartYear { get; set; }
        public int StopYear { get; set; }
        public int StartMonth { get; set; } //Gerçekleşmenin girileceği ay
        public int StartDay { get; set; } //Gerçekleşmenin girileceği gün
        public decimal BaseValue { get; set; } 
        public decimal TargetValue { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual Periot Periot { get; set; }
        public virtual PerformanceType PerformanceType { get; set; }
        public virtual PerformanceAim PerformanceAim { get; set; }
        //public virtual Organization Organization { get; set; }
        public virtual PerformancePeriot PerformancePeriot { get; set; }
        public virtual List<Performance_Target_Result> Performance_Target_Results { get; set; }
     //   public virtual List<PerformanceMatchTarget> PerformanceMatchTargets { get; set; }
    }
}
