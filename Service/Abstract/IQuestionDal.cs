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
        /*    public List<Question> getAimList(int projectId);
            public List<Question> getTargetList(int projectId,int aimId);
            public List<Question> getProjectTargetList(int projectId);
          */
        public List<QuestionHorizontal> getTargetList( int questionId);
        public Question getQuestion(int questionId);
        public int addQuestion(Question question);
        public int addQuestionHorizontal(QuestionHorizontal questionHorizontal);
        public void editQuestionIndex(EditProjectIndexDto editQuestion);
        public void editQuestion(Question question);
    }
}
