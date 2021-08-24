using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public interface IEfProjectDal
    {
        public List<Project> Projects(int periotID);
        public Project GetProjectQuestion(int projectID);
    }
}
