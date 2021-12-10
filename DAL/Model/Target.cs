using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Target
    {
        public int Id { get; set; }
        public string TargetId { get; set; }

        public string Explanation { get; set; }
        public int AimId { get; set; }
        public DateTime? InsertTime { get; set; }

        public virtual List<Action> Actions { get; set; }
        [JsonIgnore]
        public virtual Aim Aim { get; set; }
    }
}
