using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
    public partial class Project:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PeriotId { get; set; }
        public int SuccesCount { get; set; }
        public DateTime? InsertTime { get; set; }
        [JsonIgnore]

        public virtual Periot Periot { get; set; }
        
        public virtual List<Question> Questions { get; set; }

    }
}
