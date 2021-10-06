using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfTargetDal
    {
        public List<Target> TargetListFull();
        public List<Target> TargetList(int periotId);
        public void AddTarget( Target Target);
        public void DeleteTarget(int id);
        
    }
}
