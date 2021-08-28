using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
   public interface IEfPeriotDal
    {
        public void createPeriot(string name, int start, int stop);
        public void editPeriot(int id, string name);

        public List<Periot> listPeriot();
    }
}
