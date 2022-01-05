using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfSubActionDal
    {
        public List<DAL.Model.SubAction> SubActionListFull(int periotId);
        public List<SubActionDto> SubActionActionTargetAimListFull(int periotId);
        public List<DAL.Model.SubAction> ListFullPlan(int periotId);
        public void EditAction(int id, int newActionId);
        public void EditSubAction(SubAction action);
        public List<DAL.Model.SubAction> SubActionList(int actionId);
        public void AddSubAction(DAL.Model.SubAction SubAction);
        public int GetOrganizationId(int actionId);
        // public int GetSubActionActionId(int actionId);
        public void DeleteSubAction(int id);
        
    }
}
