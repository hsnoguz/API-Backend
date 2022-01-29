using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface IManualPageManager
    {
        public IResultData<int> InsertManualPage(ManualPage manaulPage);
        public IResult EditManualPage(ManualPage manaulPage);
        public IResult DeleteManualPage(int Id);
        public IResultData<ManualPage> GetManualPage(int Id);
    }
}
