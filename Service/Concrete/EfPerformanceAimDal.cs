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
    public class EfPerformanceAimDal : IEfPerformanceAimDal
    {
        IRepository<PerformanceAim> _repository;
        public EfPerformanceAimDal(IRepository<PerformanceAim> repository)
        {
            _repository = repository;
        }

        public List<PerformanceAim> PerformanceAimList()
        {
            return _repository.Table.ToList();
        }

        public string AimValue(int Id)
        {
            return _repository.Table.Where(x => x.Id == Id).Select(x=>x.Explanation).FirstOrDefault();
        }

   /*     public void EditPerformanceAim(PerformanceAim performanceAim)
        {
            PerformanceAim _performanceAim= _repository.GetById(performanceAim.Id);
            _performanceAim.Explanation = performanceAim.Explanation;
            
            _repository.Update(performanceAim);
        }*/
    }
}
