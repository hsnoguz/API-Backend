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
using Service.Enum;

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

            var result = _repositoryProject.UpdateSql("EXEC sp_TableColumnControl @table,@columnName,@result OUTPUT", new SqlParameter("@table", tableName.ToString()), new SqlParameter("@columnName", columnName.ToString()), parameterReturn);
            int returnValue = (int)parameterReturn.Value;
            return returnValue.ToString() == "1";
        }
        public void AddColumn(string tableName, string columnName,string type)
        {
                _repositoryProject.UpdateSql("sp_AddColumn @table,@columnName,@type", new SqlParameter("@table", tableName.ToString()), new SqlParameter("@columnName", columnName.ToString()), new SqlParameter("@type", type.ToString()));
        }

        public void SetColumnValue(ProjectColumnValueDto projectColumnValue) {
            SqlParameter[] sqlParameters = new SqlParameter[projectColumnValue.ColumnValues.Count+1];
            string updateString = "";
            Int16 counter = 0;
            foreach (var column in projectColumnValue.ColumnValues)
            {
                sqlParameters[counter] = new SqlParameter("@" + column.Key  , column.Value);
                if (updateString != "") updateString += ",";
                updateString += "[" + column.Key + "]=@" + column.Key;
                counter++;
            }
            sqlParameters[counter] = new SqlParameter("@Id", projectColumnValue.SurveyId);
            _repositoryProject.UpdateSql("update p" + projectColumnValue.ProjectId + " set " + updateString + " where Id=@Id", sqlParameters); 
        }

        public int AddProjectQuestion(Question question)
        {

            ColumnOperation(question);
            return _efQuestionDal.addQuestion(question);

        }

        public void ColumnOperation(Question question)
        {
            if (question.Type == QuestionType.SingleMatris.ToString())
            {
                string tableName = "p" + question.ProjectId;
                foreach (var item in question.QuestionHorizontals)
                {
                    columnProvider(tableName, item.ColumnName, "smallint");
                }
                bool isOpen= question.QuestionVerticals.Where(x => x.IsOpen == true).Any();
                if (isOpen)
                {
                    foreach (var item in question.QuestionHorizontals)
                    {
                        columnProvider(tableName, item.ColumnName, "varchar(250)");
                    }
                }
            }
        }

        public int InsertSurvey(string guid)
        {
            int projectId = _repositoryProject.Table.Include(x => x.Questions).Where(x => x.Guid == guid).FirstOrDefault().Id;
            string tableName ="p" + projectId.ToString() ;
            int Id = 0;
            var parameterReturn = new SqlParameter
            {
                ParameterName = "result",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
            };

            var result = _repositoryProject.UpdateSql("EXEC  sp_InsertSurvey @tableName,@result OUTPUT", new SqlParameter("@tableName", tableName.ToString()), parameterReturn);
            int returnValue = (int)parameterReturn.Value;
            Id = Convert.ToInt32(returnValue.ToString());
            return Id;
        }
        public void columnProvider(string tableName, string columnName, string type)
        {
            if (!columnControl(tableName, columnName))
            {
                AddColumn(tableName, columnName, type);
            }
        }

        public Project GetProjectQuestion(int projectID)
        {
            var projeQuestions=  _repositoryProject.Table.Include(x=>x.Questions).Where(x=>x.Id==projectID).FirstOrDefault();
      //      if (projeQuestions.Questions == null)
            {
                projeQuestions.Questions = _efQuestionDal.getQuestionList(projectID);
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
        public void SendSurveyStatu(string tableName, int projectId, Int16 statu, int Id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            string updateString = "";
       
                sqlParameters[0] = new SqlParameter("@tableName" ,tableName);
            sqlParameters[1] = new SqlParameter("@projectId", projectId);
            sqlParameters[2] = new SqlParameter("@statu", statu);
            sqlParameters[3] = new SqlParameter("@Id", Id);


            
            _repositoryProject.UpdateSql("sp_SuccessSurvey @tableName,@projectId,@statu,@Id", sqlParameters);
        }

        public Project GetProjectQuestionGuid(string guid)
        {
            var projeQuestions = _repositoryProject.Table.Include(x => x.Questions).Where(x => x.Guid == guid).FirstOrDefault();
            if (projeQuestions.Questions == null)
            {
             if (projeQuestions!=null)
                {

                    projeQuestions.Questions = _efQuestionDal.getQuestionList(projeQuestions.Id);
                }
                else
                {
                    throw new Exception("Not Found Project");
                }
                
            }

            foreach (var question in projeQuestions.Questions)
            {
                question.QuestionHorizontals = _efQuestionHorizontalDal.getQuestionHorizontal(question.Id);
                question.QuestionVerticals = _efQuestionVertical.getQuestionVertical(question.Id);
            }


            return projeQuestions;
        }

        public void EditQuestionIndex(List<EditProjectIndexDto> editProjectIndexDtos)
        {
            foreach (var editQuestionId in editProjectIndexDtos)
            {
                _efQuestionDal.editQuestionIndex(editQuestionId);
            }
        }

        public void EditQuestion(Question question)
        {
            ColumnOperation(question);
            _efQuestionDal.editQuestion(question);

        }
        public List<QuestionHorizontal> getTargetList(int questionId)
        {
            return _efQuestionDal.getTargetList(questionId);
        }

        public int AddProjectQuestionHorizantal(QuestionHorizontal questionHorizontal)
        {
          return _efQuestionDal.addQuestionHorizontal(questionHorizontal);
        }


        /*     public List<Question> getAimList(int projectId)
             {
                 return _efQuestionDal.getAimList(projectId);
             }

             public List<Question> getTargetList(int projectId, int aimId)
             {
                 return _efQuestionDal.getTargetList(projectId,aimId);
             }

             public List<Question> getProjectTargetList(int projectId)
             {
                 return _efQuestionDal.getProjectTargetList(projectId);
             }*/
    }
}
