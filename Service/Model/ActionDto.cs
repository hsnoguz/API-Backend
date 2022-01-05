using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class ActionDto:ICustomEntity
    {
        public int Id { get; set; }
        public string ActionId { get; set; }
        public string Explanation { get; set; }
        public string TargetExplanation { get; set; }
        public string AimExplanation { get; set; }
        public string OrganizationExplanation { get; set; }
    }
}
