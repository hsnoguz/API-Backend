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
        public void AddProjectQuestion(Question question)
        {

            _efQuestionDal.addQuestion(question);
            
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
