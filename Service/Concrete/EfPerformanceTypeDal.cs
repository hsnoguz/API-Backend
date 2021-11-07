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
    }
}
