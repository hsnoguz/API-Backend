using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
public interface IPeriotManager
    {
        public IResult createPeriot(string name, int startYear, int stopYear);
        public IResult editPeriot(int id, string name);
        public IResultData<List<Periot>> listPeriot();
        public IResultData<Periot> currentPeriot(int Id);
    }
}
