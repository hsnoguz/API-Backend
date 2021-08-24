using DAL.Model;
using Repository;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfQuestionDal : IEfQuestionDal
    {
        IRepository<Question> _repository;
        public EfQuestionDal(IRepository<Question> repository)
        {
            _repository = repository;
        }
        public List<Question> getQuestion(int projectId)
        {
            List<Question> question= _repository.Table.Where(x=>x.ProjectId==projectId).ToList();
            return question;
        }
    }
}
