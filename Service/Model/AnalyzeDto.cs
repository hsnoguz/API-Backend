using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
   public  class AnalyzeDto: ICustomEntity
    {
        public int Id { get; set; }
        public string Soru { get; set; }
        public decimal? Puan { get; set; }
        public string? Sonuc { get; set; }
    }
}
