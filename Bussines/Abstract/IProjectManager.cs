using Core.Results;
using DAL.Model;
using Service.Model;
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
        public IResultData<Project> GetProjectQuestion(string guid);
        public IResultData<Project> GetProjectQuestion(int Id);
        public IResult CreateProject(CustomProjectDto project);
        public IResult AddProject(Question question);
        public IResult SetColumnValue(string tableName, string columnValue, int Id);
        public IResultData<int> insertSurvey(string tableName);
        public IResult SendSurveyStatu(string tableName, int projectId, Int16 statu, int Id);
    }
}
