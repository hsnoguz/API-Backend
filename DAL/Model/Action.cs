using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
 public   class Action
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        public int TargetId { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual List<SubAction> SubActions { get; set; }
    }
}
