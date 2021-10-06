using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfSubActionDal
    {
        public List<DAL.Model.SubAction> SubActionListFull();
        public List<DAL.Model.SubAction> SubActionList(int periotId);
        public void AddSubAction(DAL.Model.SubAction SubAction);
        public void DeleteSubAction(int id);
        
    }
}
