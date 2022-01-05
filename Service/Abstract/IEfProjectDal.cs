using DAL.Model;
using Service.Model;
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
      //  public List<Question> getAimList(int projectId);
        public List<QuestionHorizontal> getTargetList(int questionId);
 //       public List<Question> getProjectTargetList(int projectId);

        public Project GetProjectQuestionGuid(string guid);
        public void CreateProject(CustomProjectDto project);
        public int AddProjectQuestion(Question question);
        public int AddProjectQuestionHorizantal(QuestionHorizontal questionHorizontal);
        public void SetColumnValue(ProjectColumnValueDto projectColumnValue);
        public void EditQuestionIndex(List<EditProjectIndexDto> editProjectIndexDtos);
        public void EditQuestion(Question question);
        public int InsertSurvey(string guid);
        public void SendSurveyStatu(string tableName,int projectId,Int16 statu,int Id);
    }
}
