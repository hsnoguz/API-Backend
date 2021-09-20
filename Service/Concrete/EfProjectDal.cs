using DAL.Model;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using Microsoft.Data.SqlClient;
using Service.Enums;

namespace Service.Concrete
{
    public class EfProjectDal : IEfProjectDal
    {
        public ManagerContext _context;
        public IRepository<Project> _repositoryProject;
        public IEfQuestionDal _efQuestionDal;
        public IEfQuestionHorizontalDal _efQuestionHorizontalDal;
        public IEfQuestionVerticalDal _efQuestionVertical;
        public EfProjectDal(ManagerContext context, IRepository<Project> repositoryProject, IEfQuestionDal efQuestionDal, IEfQuestionHorizontalDal efQuestionHorizontalDal, IEfQuestionVerticalDal efQuestionVertical)
        {
            _context = context;
            _repositoryProject = repositoryProject;
            _efQuestionHorizontalDal = efQuestionHorizontalDal;
            _efQuestionVertical = efQuestionVertical;
            _efQuestionDal = efQuestionDal;
        }

        public void CreateProject(CustomProjectDto project)
        {
            Project tempProject = new Project();
            tempProject.Name = project.Name;
            tempProject.PeriotId = project.PeriotId;
            tempProject.StartTime = project.StartTime;
            tempProject.StopTime = project.StopTime;
            _repositoryProject.Insert(tempProject);
            int Id = tempProject.Id;
            createTable(Id);

            //var table = _context.Database.<SurveyTempTable>("SELECT ... FROM " + project.Name);
        }

        public void createTable(int Id)
        {
            var result = _repositoryProject.UpdateSql("sp_CreateProjectTable @Id", new SqlParameter("@Id",Id.ToString()));
        }

        public bool columnControl(string tableName,string columnName)
        {
            var parameterReturn = new SqlParameter
            {
                ParameterName = "result",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
            };

            var result = _repositoryProject.UpdateSql("EXEC @result = sp_TableColumnControl @table,@columnName", new SqlParameter("@table", tableName.ToString()), new SqlParameter("@columnName", columnName.ToString()), parameterReturn);
            int returnValue = (int)parameterReturn.Value;
            return returnValue.ToString() == "1";
        }
        public void addColumn(string tableName, string columnName,string type)
        {
                _repositoryProject.UpdateSql("sp_AddColumn @table,@columnName,@type", new SqlParameter("@table", tableName.ToString()), new SqlParameter("@columnName", columnName.ToString()), new SqlParameter("@type", type.ToString()));
        }

        public void setColumnValue(string tableName,Dictionary<string,string> columnValue,int Id) {
            SqlParameter[] sqlParameters = new SqlParameter[columnValue.Count];
            string updateString = "";
            foreach (var column in columnValue)
            {
                sqlParameters[0] = new SqlParameter("@" + column.Key  , column.Value);
                if (updateString != "") updateString += ",";
                updateString += "[" + column.Key + "]=@" + column.Key;
            }
            sqlParameters[0] = new SqlParameter("@Id",Id);
            _repositoryProject.UpdateSql("update " + tableName + " set " + updateString + " where Id=@Id", sqlParameters); 
        }

        public void AddProjectQuestion(Question question)
        {

            columnOperation(question);
            _efQuestionDal.addQuestion(question);

        }
        public void columnOperation(Question question)
        {
            if (question.Type == QuestionType.SingleMatris.ToString())
            {

                foreach (var item in question.QuestionHorizontals)
                {
                    string tableName = "p" + question.ProjectId;
                    if (!columnControl(tableName, item.ColumnName))
                    {
                        addColumn(tableName, item.ColumnName, "smallint");
                    }

                }
            }
        }

        public Project GetProjectQuestion(int projectID)
        {
            var projeQuestions=  _repositoryProject.Table.Include(x=>x.Questions).Where(x=>x.Id==projectID).FirstOrDefault();
            if (projeQuestions.Questions == null)
            {
                projeQuestions.Questions = _efQuestionDal.getQuestion(projectID);
            }

            foreach (var question in projeQuestions.Questions)
            {
                question.QuestionHorizontals = _efQuestionHorizontalDal.getQuestionHorizontal(question.Id);
                question.QuestionVerticals = _efQuestionVertical.getQuestionVertical(question.Id);
            }


            return projeQuestions;
        }

        public List<Project> Projects(int periotId)
        {
            return _repositoryProject.Table.Where(x => x.PeriotId == periotId).ToList();
        }
    }
}
