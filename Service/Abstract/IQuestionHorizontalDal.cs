using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfQuestionHorizontalDal
    {
        public List<QuestionHorizontal> getQuestionHorizontal( int questionId);
        public List<QuestionHorizontal> getQuestionHorizontalTarget(int questionId);
        public void HorizantalInsert(QuestionHorizontal questionHorizontal);
    }
}
