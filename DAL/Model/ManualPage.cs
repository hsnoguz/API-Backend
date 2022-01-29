using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class ManualPage
    {
        public int Id { get; set; }
        public int LeftMenuId { get; set; }
        public int PeriotId { get; set; }
        public string Explanation{ get; set; }
        public DateTime? InsertTime { get; set; }
        
    }
}
