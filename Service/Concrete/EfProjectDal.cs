using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfProjectDal : IEfProjectDal
    {
        public IRepository<Project> _repositoryProject;
        public IEfQuestionDal _efQuestionDal;
        public IEfQuestionHorizontalDal _efQuestionHorizontalDal;
        public IEfQuestionVerticalDal _efQuestionVertical;
        public EfProjectDal(IRepository<Project> repositoryProject, IEfQuestionDal efQuestionDal, IEfQuestionHorizontalDal efQuestionHorizontalDal, IEfQuestionVerticalDal efQuestionVertical)
        {
            _repositoryProject = repositoryProject;
            _efQuestionHorizontalDal = efQuestionHorizontalDal;
            _efQuestionVertical = efQuestionVertical;
            _efQuestionDal = efQuestionDal;
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
