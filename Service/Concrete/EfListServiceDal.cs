using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfListServiceDal<T> : IEfListServiceDal<T> where T : class
    {
        public IRepository<T> _repository;
        public EfListServiceDal(IRepository<T> repository) {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Insert(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public ICollection<T> getList()
        {
            return (ICollection<T>)_repository.Table.ToList();

        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
