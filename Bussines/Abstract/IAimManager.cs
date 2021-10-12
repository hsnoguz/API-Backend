using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface IAimManager
    {
        public List<Aim> AimList(int periotId);
        public IResult EditAim(int id, string explanation);
        public IResult AddAim( Aim aim);
        public IResult DeleteAim( int id);

    }
}
