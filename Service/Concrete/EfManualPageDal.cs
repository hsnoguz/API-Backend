using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfManualPageDal : IEfManualPageDal
    {
        public IRepository<ManualPage> _repository;
        public EfManualPageDal(IRepository<ManualPage> repository)
        {
            _repository = repository;
        }
        public void DeleteManualPage(int Id)
        {
            var manualPage = _repository.GetById(Id);
            _repository.Delete(manualPage);
        }

        public void EditManualPage(ManualPage manaulPage)
        {
            var manualPage = _repository.GetById(manaulPage.Id);
            manualPage.Explanation = manaulPage.Explanation;
            manualPage.LeftMenuId = manaulPage.LeftMenuId;
            manualPage.PeriotId = manualPage.PeriotId;
            _repository.Update(manualPage);
        }

        public ManualPage GetManualPage(int Id)
        {
            var manualPage = _repository.GetById(Id);
            return manualPage;
        }

        public int InsertManualPage(ManualPage manaulPage)
        {
            _repository.Insert(manaulPage);
            return manaulPage.Id;
        }
    }
}
