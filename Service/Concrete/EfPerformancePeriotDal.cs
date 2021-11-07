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
    public class EfPerformancePeriotDal : IEfPerformancePeriotDal
    {
        IRepository<PerformancePeriot> _repository;
        public EfPerformancePeriotDal(IRepository<PerformancePeriot> repository)
        {
            _repository = repository;
        }

        public List<PerformancePeriot> PeriotList()
        {
            return _repository.Table.ToList();
        }

        public short PeriotValue(int Id)
        {
            return _repository.Table.Where(x => x.Id == Id).Select(x=>x.Explanation).FirstOrDefault();
        }
    }
}
