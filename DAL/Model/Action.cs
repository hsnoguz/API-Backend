using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
 public   class Action
    {
        public int Id { get; set; }
   
        public string ActionId { get; set; }
        public string Explanation { get; set; }
        public int TargetId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? InsertTime { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual List<SubAction> SubActions { get; set; }
        [JsonIgnore]
        public virtual Target Target { get; set; }

    }
}
