using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface IProjectManager
    {
        
        public IResultData<List<Project>> Projects(int periotID);
        public IResultData<Project> GetProjectQuestion(int Id);
        
    }
}
