using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfTargetDal
    {
        public List<Target> TargetListFull(int periotId);

        public void EditAim(int id, int aimId);
        public void EditTarget(int id, int aimId, string explanation);

        public List<Target> TargetList(int aimId);
        public List<TargetDto> TargetAimList(int periotId);

        public void AddTarget( Target Target);
        public void DeleteTarget(int id);

        public int GetTargetAimId(int targetId);
        
    }
}
