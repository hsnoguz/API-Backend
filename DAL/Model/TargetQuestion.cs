using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class TargetQuestion
    {
        public int Id { get; set; }
  
        public string Explanation { get; set; }
        public int AimQuestionId { get; set; }
        public DateTime? InsertTime { get; set; }
       // public int ActionId { get; set; }
        public virtual List<Question> Questions { get; set; }
     //   public virtual Aim Aim { get; set; }
    }
}
