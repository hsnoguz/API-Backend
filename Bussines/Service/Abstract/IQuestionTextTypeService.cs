using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
   public interface IQuestionTextTypeService
    {
        public IResultData<List<QuestionTextType>> questionTextTypes();
    }
}
