using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
 public   class SubAction
    {
        public int Id { get; set; }

        public string SubActionId { get; set; }
        public string Explanation { get; set; }
        public int ActionId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? InsertTime { get; set; }
        [JsonIgnore]
        public virtual Action Action { get; set; }
    }
}
