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
        public List<DAL.Model.Action> ActionListFull(int periotId);
        public void EditTarget(int id, int targetId);
        public void EditAction(DAL.Model.Action action);
        public List<DAL.Model.Action> ActionList(int periotId);
        public void AddAction(DAL.Model.Action action);
        public int GetActionTargetId(int actionId);
        public int GetOrganizationId(int actionId);
        public int GetActionAimId(int targetId);
        public void DeleteAction(int id);
        
    }
}
