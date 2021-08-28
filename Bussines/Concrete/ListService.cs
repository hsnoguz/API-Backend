using Bussines.Abstract;
using Core.Results;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    
    public class ListService<T> : IListService<T> where T : class
    {
        IEfListServiceDal<T> _efListService;
        public ListService(IEfListServiceDal<T> efListService)
        {
            _efListService = efListService;
        }


        public IResult Add(T entity)
        {
            try
            {
                _efListService.Insert(entity);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(T entity)
        {
            try
            {
                _efListService.Delete(entity);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
           
        }

        public IResultData<T> getEntity(int Id)
        {
            return new SuccessResultData<T>(_efListService.GetById(Id));
        }

        public IResultData<List<T>> getList()
        {

            return new SuccessResultData<List<T>>(_efListService.Table.ToList());
        }

        public IResult Update(T entity)
        {
            try
            {
                _efListService.Update(entity);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
    }
}
