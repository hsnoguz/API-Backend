using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface ITargetManager
    {
        public List<Target> TargetListFull();
        public IResult EditAim(int id, int aimId);
        public IResult EditTarget(int id, int aimId, string explanation);

        public List<Target> TargetList(int aimId);
        public IResult AddTarget(Target target);
        public IResult DeleteTarget( int id);

    }
}
