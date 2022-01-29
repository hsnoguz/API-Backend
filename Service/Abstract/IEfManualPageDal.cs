using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
   public interface IEfManualPageDal
    {
        public int InsertManualPage(ManualPage manaulPage);
        public void EditManualPage(ManualPage manaulPage);
        public void DeleteManualPage(int Id);
        public ManualPage GetManualPage(int Id);
    }
}
