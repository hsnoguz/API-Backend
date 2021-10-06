using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface ISubActionManager
    {
        public List<DAL.Model.SubAction> SubActionListFull();
        public List<DAL.Model.SubAction> SubActionList(int actionId);
        public IResult AddSubAction(DAL.Model.SubAction SubAction);
        public IResult DeleteSubAction( int id);

    }
}
