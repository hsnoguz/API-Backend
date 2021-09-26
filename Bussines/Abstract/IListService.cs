using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface IListService<T> where T:class
    {
        public IResultData<List<T>> getList();
        public IResultData<T> getEntity(int Id);
        public IResult Add(T entity);
        public IResult Delete(int entity);
        public IResult Update(T entity);
    }
}
