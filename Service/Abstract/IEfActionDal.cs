using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfActionDal
    {
        public List<DAL.Model.Action> ActionListFull();
        public List<DAL.Model.Action> ActionList(int periotId);
        public void AddAction(DAL.Model.Action action);
        public void DeleteAction(int id);
        
    }
}
