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
    public class EfQuestionVerticalDal : IEfQuestionVerticalDal
    {
        IRepository<QuestionVertical> _repository;
        public EfQuestionVerticalDal(IRepository<QuestionVertical> repository)
        {
            _repository = repository;
        }
        public List<QuestionVertical> getQuestionVertical(int questionId)
        {
            List<QuestionVertical> questionVerticals = _repository.Table.Where(x => x.QuestionId == questionId).ToList();
            return questionVerticals;
        }
    }
}
