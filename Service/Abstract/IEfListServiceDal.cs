using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
   public interface IEfListServiceDal<T>: IRepository<T> where T:class
    {
     /*   public ICollection<T> getList();
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);*/
    }
}
