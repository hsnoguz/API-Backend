using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfActionPriceDal
    {
        public void InsertActionPrice(ActionPrice actionMatchPrice);
        //public void EditActionPrice(ActionPrice actionMatchPrice);
        public void SetActionPriceResult(int Id,decimal Result);
        public void DeleteActionPrice(int Id);
        public List<ActionPriceMatchDto> ListActionPrice(int roleId, int organizationId, int periotId);
        public List<ActionPriceMatchDto> ListActionSubActionPrice(int roleId, int organizationId, int periotId);
        public List<ActionPriceMatchDto> ListSubActionPrice(int roleId, int organizationId, int periotId);
    }
}
