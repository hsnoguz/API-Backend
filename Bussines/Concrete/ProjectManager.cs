using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public IResult AddProject(Question question)
        {
            try
            {
                _projectDal.AddProjectQuestion(question);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
         
        }

        public IResult CreateProject(CustomProjectDto project)
        {
            try
            {
                _projectDal.CreateProject(project);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResultData<Project> GetProjectQuestion(int Id)
        {
            return new SuccessResultData<Project>(_projectDal.GetProjectQuestion(Id));
        }

        public IResultData<List<Project>> Projects(int periotID)
        {
            return new SuccessResultData<List<Project>>(_projectDal.Projects(periotID));
        }

        public IResult SetColumnValue(ProjectColumnValueDto projectColumnValue)
        {
            try
            {
                _projectDal.SetColumnValue(projectColumnValue);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        
            return new SuccessResult();
        }

        public IResultData<int> insertSurvey(string guid)
        {
          
            return new SuccessResultData<int>(_projectDal.InsertSurvey(guid));
        }
        public IResult SendSurveyStatu(string tableName, int projectId, Int16 statu, int Id)
        {
            try
            {
                _projectDal.SendSurveyStatu(tableName, projectId, statu, Id);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
            return new SuccessResult();
        }

        public IResultData<Project> GetProjectQuestionGuid(string guid)
        {
            return new SuccessResultData<Project>(_projectDal.GetProjectQuestionGuid(guid));
        }

        public IResult EditQuestionIndex(List<EditProjectIndexDto> editProjectIndexDtos)
        {
            List<int> Indexs = new();
            foreach (var item in editProjectIndexDtos)
            {
                if (Indexs.Contains(item.QuestionIndex))
                {
                    return new ErrorResult("Duplicate Index Question");
                }
                else
                {
                    Indexs.Add(item.QuestionIndex);
                }
            }
            _projectDal.EditQuestionIndex(editProjectIndexDtos);
            return new SuccessResult();
        }

        public IResult EditQuestion(Question question)
        {
            try
            {
                _projectDal.EditQuestion(question);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
            return new SuccessResult();
        }
    }
}
