using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public  interface IEfQuestionDal
    {
        public List<Question> getQuestionList(int projectId);
        public Question getQuestion(int questionId);
        public void addQuestion(Question question);
        public void editQuestionIndex(EditProjectIndexDto editQuestion);
        public void editQuestion(Question question);
    }
}
