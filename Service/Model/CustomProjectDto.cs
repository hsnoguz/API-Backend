using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class CustomProjectDto: ICustomEntity
    {
        public string Name { get; set; }
        public int PeriotId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }

    }
}
