using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfPerformanceTypeDal
    {
        public string TypeValue(int Id);
        public List<PerformanceType> PerformanceTypeList();
    }
}
