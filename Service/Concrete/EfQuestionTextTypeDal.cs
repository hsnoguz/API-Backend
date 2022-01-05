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
    public class EfQuestionTextTypeDal : IEfQuestionTextTypeDal
    {
        IRepository<QuestionTextType> _repository;
        public EfQuestionTextTypeDal(IRepository<QuestionTextType> repository)
        {
            _repository = repository;
        }
        public List<QuestionTextType> questionTextTypes()
        {
            return _repository.Table.ToList();
        }
    }
}
