using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IEfLeftMenuDal
    {
        public List<LeftMenu> GetLeftMenu(int roleId, int userId);
        public List<LeftMenuClaimDto> GetLeftMenuFull();

        public void AddLeftMenu(LeftMenu leftMenu);
        public void DeleteLeftMenu(int Id);
        public void EditLeftMenu(LeftMenu leftMenu);
    }
}
