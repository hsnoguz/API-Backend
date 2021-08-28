using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
  public interface IOrganizationService : IListService<Organization>
    {
        /* public IResultData<Jop> getLJop(int Id);
       public IResultData<List<Jop>> getList();
        public IResult Add(Jop entity);
        public IResult Delete(Jop entity);
        public IResult Update(Jop entity);*/
    }
}
