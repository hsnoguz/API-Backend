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
   public interface ISubActionManager
    {
        public List<DAL.Model.SubAction> SubActionListFull(int periotId);
        public List<DAL.Model.SubAction> ListFullPlan(int periotId);

        public List<SubActionDto> SubActionActionTargetAimList(int periotId);

        public IResult EditAction(int id, int newActionId);
        public IResult EditSubAction(SubAction subAction);

        public List<DAL.Model.SubAction> SubActionList(int actionId);
        public IResult AddSubAction(DAL.Model.SubAction SubAction);
        public IResult DeleteSubAction( int id);
        public IResultData<int> GetOrganizationId(int subActionId);

    }
}
