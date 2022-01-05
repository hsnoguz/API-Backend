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
    public class EfAimQuestionDal : IEfAimQuestionDal
    {
        IRepository<AimQuestion> _repository;
        public EfAimQuestionDal(IRepository<AimQuestion> repository) {
            _repository = repository;
        }
        public void addAim(AimQuestion question)
        {
            AimQuestion _question = new AimQuestion(); ;
            _question.ProjectId = question.ProjectId;
            _question.Explanation = question.Explanation;
            
            _repository.Insert(_question);
        }

        public void deleteAim(int aimId)
        {
            AimQuestion aimQuestion = _repository.GetById(aimId);
            _repository.Delete(aimQuestion);
        }

        public void editAim(AimQuestion question)
        {
            AimQuestion _question = new AimQuestion(); ;
   
            _question.Explanation = question.Explanation;

            _repository.Insert(_question);
        }

    
        public List<AimQuestion> getAimQuestionList(int projectId)
        {
            return _repository.Table.Include(x=>x.TargetQuestions).Where(x=>x.ProjectId==projectId).ToList();
        }

        public List<Question> getQuestionList(int aimId)
        {
            throw new NotImplementedException();
        }

        List<AimQuestion> IEfAimQuestionDal.getAimList(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
