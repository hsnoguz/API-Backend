using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class ProjectManager : IProjectManager
    {
        IEfProjectDal _projectDal;
        public ProjectManager(IEfProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResultData<Project> GetProjectQuestion(int Id)
        {
            return new SuccessResultData<Project>(_projectDal.GetProjectQuestion(Id));
        }

        public IResultData<List<Project>> Projects(int periotID)
        {
            return new SuccessResultData<List<Project>>(_projectDal.Projects(periotID));
        }

    }
}
