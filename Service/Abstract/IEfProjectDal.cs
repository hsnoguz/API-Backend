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
        public Project GetProjectQuestion(string guid);
        public void CreateProject(CustomProjectDto project);
        public void AddProjectQuestion(Question question);
        public void SetColumnValue(string tableName, Dictionary<string, string> columnValue, int Id);
        public int InsertSurvey(string tableName);
        public void SendSurveyStatu(string tableName,int projectId,Int16 statu,int Id);
    }
}
