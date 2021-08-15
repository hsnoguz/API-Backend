using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SecondModel
{
   public partial class Question
    {
        public int Id { get; set; }
        public string ColumnName { get; set; }
        public string Text { get; set; }
        public int Index { get; set; }
        public int ParentId { get; set; }

    }
}
