using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfPerformancePeriotDal
    {
        public Int16 PeriotValue(int Id);
        public List<PerformancePeriot> PeriotList();
    }
}
