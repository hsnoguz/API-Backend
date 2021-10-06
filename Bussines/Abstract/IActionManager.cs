using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface IActionManager
    {
        public List<DAL.Model.Action> ActionListFull();
        public List<DAL.Model.Action> ActionList(int targetId);
        public IResult AddAction(DAL.Model.Action Action);
        public IResult DeleteAction( int id);

    }
}
