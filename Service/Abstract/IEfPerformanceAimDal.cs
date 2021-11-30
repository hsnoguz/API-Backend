using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfPerformanceAimDal
    {
        public string AimValue(int Id);
        public List<PerformanceAim> PerformanceAimList();
 
    
    }
}
