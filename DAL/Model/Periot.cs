using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Periot: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartYear { get; set; }
        public int StopYear { get; set; }
        public DateTime? InsertTime { get; set; }
      //  public virtual List<Aim> Aims { get; set; }
     
    }
}
