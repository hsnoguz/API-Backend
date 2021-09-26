using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public  class Aim
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public int PeriotId { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual List<Target> Targets { get; set; }


    }
}
