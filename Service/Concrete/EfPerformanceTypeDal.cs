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
    public class EfPerformanceTypeDal : IEfPerformanceTypeDal
    {
        IRepository<PerformanceType> _repository;
        public EfPerformanceTypeDal(IRepository<PerformanceType> repository)
        {
            _repository = repository;
        }

        public List<PerformanceType> PerformanceTypeList()
        {
            return _repository.Table.ToList();
        }

        public string TypeValue(int Id)
        {
            return _repository.Table.Where(x => x.Id == Id).Select(x=>x.Explanation).FirstOrDefault();
        }

        public void EditPerformanceType(PerformanceType performanceType)
        {
            PerformanceType _performanceType = _repository.GetById(performanceType.Id);
            _performanceType.Explanation = performanceType.Explanation;
            _repository.Update(_performanceType);
        }

        public void InsertPerformanceType(PerformanceType performanceType)
        {
            _repository.Insert(performanceType);
        }
    }
}
