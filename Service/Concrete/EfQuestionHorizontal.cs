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
    public class EfQuestionHorizontalDal : IEfQuestionHorizontalDal
    {
        IRepository<QuestionHorizontal> _repository;
        public EfQuestionHorizontalDal(IRepository<QuestionHorizontal> repository)
        {
            _repository = repository;
        }
        public List<QuestionHorizontal> getQuestionHorizontal(int questionId)
        {
            List<QuestionHorizontal> questionHorizontals= _repository.TableNoTracking.Where(x=>x.QuestionId==questionId).ToList();
            return questionHorizontals;
        }

        public List<QuestionHorizontal> getQuestionHorizontalTarget(int questionId)
        {
            List<QuestionHorizontal> questionHorizontals = _repository.TableNoTracking.Where(x => x.QuestionId == questionId && (x.ColumnName==null || x.ColumnName =="")).ToList();
            return questionHorizontals;
        }

        public void HorizantalInsert(QuestionHorizontal questionHorizontal)
        {
                _repository.Insert(questionHorizontal);   
        }
    }
}
