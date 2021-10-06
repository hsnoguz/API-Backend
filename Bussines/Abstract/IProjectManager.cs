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
        public IResultData<Project> GetProjectQuestionGuid(string guid);
        public IResultData<Project> GetProjectQuestion(int Id);
        public IResult CreateProject(CustomProjectDto project);
        public IResult AddProject(Question question);
        public IResult SetColumnValue(ProjectColumnValueDto projectColumnValue);
        public IResultData<int> insertSurvey(string guid);
        public IResult EditQuestionIndex(List<EditProjectIndexDto> editProjectIndexDtos);
        public IResult EditQuestion(Question question);
        public IResult SendSurveyStatu(string tableName, int projectId, Int16 statu, int Id);
    }
}
