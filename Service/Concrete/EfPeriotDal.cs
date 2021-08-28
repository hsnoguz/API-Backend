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
    public class EfPeriotDal : IEfPeriotDal
    {
        IRepository<Periot> _repository;
        public EfPeriotDal(IRepository<Periot> repository)
        {
            _repository = repository;
        }
        public void createPeriot(string name, int startYear, int stopYear)
        {
            Periot periot = new Periot { Name = name, StartYear = startYear, StopYear = stopYear };
            _repository.Insert(periot);
        }

        public void editPeriot(int id, string name)
        {
            Periot periot = _repository.GetById(id) ;
            periot.Name = name;
            _repository.Insert(periot);
        }

        public List<Periot> listPeriot()
        {
            List<Periot> listPeriot = _repository.Table.ToList();
         
           return listPeriot;
        }
    }
}
