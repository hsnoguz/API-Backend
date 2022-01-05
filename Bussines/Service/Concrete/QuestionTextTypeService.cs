using Bussines.Service.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public class QuestionTextTypeService : IQuestionTextTypeService
    {
        IEfQuestionTextTypeDal _efQuestionTextTypeDal;
        public QuestionTextTypeService(IEfQuestionTextTypeDal efQuestionTextTypeDal)
        {
            _efQuestionTextTypeDal = efQuestionTextTypeDal;
        }
        public IResultData<List<QuestionTextType>> questionTextTypes()
        {
            return new SuccessResultData<List<QuestionTextType>>(_efQuestionTextTypeDal.questionTextTypes());
        }
    }
}
