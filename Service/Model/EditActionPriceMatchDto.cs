using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
  public  class EditActionPriceMatchDto : ICustomEntity
    {
        public int Id { get; set; }
         public decimal TargetValue { get; set; }
        public decimal ResultValue { get; set; }

    }
}
