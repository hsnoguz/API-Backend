using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAL.Model
{
 public partial class V_ATFAF_Plan
    {
        public int Id { get; set; }

        public string SubActionId { get; set; }
        public string SubActionExplanation { get; set; }
        public int OrganizationId { get; set; }
        public int ActionId { get; set; }
        public string ActionListId { get; set; }
        public string ActionExplanation { get; set; }
        public int TargetId { get; set; }
        public string TargetListId { get; set; }
        public string TargetExplanation { get; set; }
        public int AimId { get; set; }
        
        public string AimExplanation { get; set; }
        public int PeriotId { get; set; }
        //     public virtual Action Action { get; set; }

    }
}
