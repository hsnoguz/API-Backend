using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
 public   class Target
    {
        public int Id { get; set; }
        public int Explanation { get; set; }
        public int AimId { get; set; }
        public DateTime? InsertTime { get; set; }
    }
}
