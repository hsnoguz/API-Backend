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
   public interface IActionManager
    {
        public List<DAL.Model.Action> ActionListFull(int periotId);
        public List<ActionDto> ActionTargetAimList(int periotId);
        public IResult EditTarget(int id, int targetId);
        public IResult EditAction(DAL.Model.Action action);

        public List<DAL.Model.Action> ActionList(int targetId);
        public IResult AddAction(DAL.Model.Action Action);
        public IResult DeleteAction( int id);
        public IResultData<int> GetOrganizationId(int id);

    }
}
