using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
 public  class Sign
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public int PeriotId { get; set; }
        public int IndicatorTypeId { get; set; }
        public int IndicatorClassId { get; set; } //Artış-Azalış-Aynı Seviye
        public int OrganizationId { get; set; }
        public int StartYear { get; set; }
        public int StopYear { get; set; }
        public int StartMonth { get; set; } //Gerçekleşmenin girileceği ay
        public int StartDay { get; set; } //Gerçekleşmenin girileceği gün
        public int BaseValue { get; set; } 
        public int TargetValue { get; set; }
        public DateTime? InsertTime { get; set; }
    }
}
