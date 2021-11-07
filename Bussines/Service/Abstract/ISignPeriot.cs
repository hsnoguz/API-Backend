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
    public interface ISignPeriot : IListService<PerformancePeriot>
    {
        public IResult AddSignPeriot(PerformancePeriot signPeriot);
        public IResult UpdateSignPeriot(int id,short explanation);
    }
}
