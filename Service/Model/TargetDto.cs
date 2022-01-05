using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
   public class TargetDto: ICustomEntity
    {
        public int Id { get; set; }
        public string TargetId { get; set; }
        public string Explanation { get; set; }
        public string AimExplanation { get; set; }

    }
}
