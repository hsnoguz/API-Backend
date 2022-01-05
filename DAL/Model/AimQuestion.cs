using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
  public partial class AimQuestion
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Explanation { get; set; }
        public bool IsActive { get; set; }
      //  public int PeriotId { get; set; }
        public DateTime? InsertTime { get; set; }
    
        public virtual List<TargetQuestion> TargetQuestions { get; set; }

     //   public virtual Periot Periot { get; set; }

    }
}
