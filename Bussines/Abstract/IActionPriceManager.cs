using Core.Results;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
  public interface IActionPriceManager
    {
        public IResult InsertActionPrice(ActionPrice actionMatchPrice);
        public IResult EditActionPrice(EditActionPriceMatchDto actionMatchPrice);
        public IResult SetActionPriceResult(int Id, decimal Result);
        public IResult DeleteActionPrice(int Id);
        public IResultData<List<ActionPriceMatchDto>> ListActionPrice(string roleName, int userId, int periotId);
        public IResultData<List<ActionPriceMatchDto>> ListActionSubActionPrice(string roleName, int userId, int periotId);
        public IResultData<List<ActionPriceMatchDto>> ListSubActionPrice(string roleName, int userId, int periotId);
    }
}
