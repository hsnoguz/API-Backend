using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class LeftMenu 
    {
        public short Id { get; set; }
        public string Description { get; set; }
        public string Src { get; set; }
        public short? MenuId { get; set; }
        public short? MenuIndex { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string OnClick { get; set; }
        public short? AccessRank { get; set; }
        public bool? IsManual { get; set; }
        public bool isActive { get; set; }

    }
}
