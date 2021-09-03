using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public partial class SurveyTempTable:IEntity
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public DateTime? InsertTime { get; set; }

    }
}
