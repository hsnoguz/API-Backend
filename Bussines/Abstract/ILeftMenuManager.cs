using Core.Results;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface ILeftMenuManager
    {
        public IResultData<List<LeftMenu>> GetLeftMenu(string roleName, int userId);
        public IResultData<List<LeftMenuClaimDto>> GetLeftMenuFull();
        public IResult AddLeftMenu(LeftMenu leftMenu);
        public IResult DeleteLeftMenu(int Id);
    }
}
