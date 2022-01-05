using DAL.Model;
using Repository;
using Service.Abstract;
using Service.Enum;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfQuestionDal : IEfQuestionDal
    {
        IRepository<Question> _repository;
        public IEfQuestionHorizontalDal _efQuestionHorizontalDal;
        public IEfQuestionVerticalDal _efQuestionVertical;
        public IEfQuestionTextTypeDal _efQuestionTextTypeDal;
        public EfQuestionDal(IRepository<Question> repository, IEfQuestionHorizontalDal efQuestionHorizontalDal, IEfQuestionVerticalDal efQuestionVertical, IEfQuestionTextTypeDal efQuestionTextTypeDal)
        {
            _repository = repository;
            _efQuestionHorizontalDal = efQuestionHorizontalDal;
            _efQuestionVertical = efQuestionVertical;
            _efQuestionTextTypeDal = efQuestionTextTypeDal;
        }

        public int addQuestion(Question question)
        {
            if (question.Type == Enum.QuestionType.SingleMatris.ToString())
            { 
                
            }
            _repository.Insert(question);
            return question.Id;
        }


        
        public List<Question> getQuestionList(int projectId)
        {
            List<Question> questionList= _repository.Table.Where(x=>x.ProjectId==projectId).ToList();
            return questionList;
        }

        public Question getQuestion(int questionId)
        {
            Question question = _repository.Table.Include(x=>x.QuestionHorizontals).Include(x=>x.QuestionVerticals).Where(x => x.Id == questionId).FirstOrDefault();
            if (question.QuestionHorizontals == null)
            {
                question.QuestionHorizontals = _efQuestionHorizontalDal.getQuestionHorizontal(question.Id);
            }
            if (question.QuestionVerticals == null)
            {
                question.QuestionVerticals= _efQuestionVertical.getQuestionVertical(question.Id);
            }
            return question;
        }

        public void editQuestionIndex(EditProjectIndexDto editQuestion)
        {
            Question question = _repository.Table.Where(x => x.Id == editQuestion.QuestionId).FirstOrDefault();
            question.Index = editQuestion.QuestionIndex;
            _repository.Update(question);

        }
        public void editQuestion(Question question)
        {
            var questionList = getQuestionList(question.ProjectId);
            var dbQuestion = getQuestion(question.Id);
            var itemCount = questionList.Where(x => x.Id != question.Id && (x.Name == question.Name)).Count();
            if (itemCount > 0)
            {
                throw new Exception("Duplicate QuestionName");
            }

            dbQuestion.Name = question.Name;
            dbQuestion.Text = question.Text;
            foreach (var horizontal in question.QuestionHorizontals)
            {
                if (dbQuestion.QuestionHorizontals.Where(x => x.Id == horizontal.Id).Count() < 1)
                {
                    dbQuestion.QuestionHorizontals.Add(new QuestionHorizontal() { Index = horizontal.Index, ParentId = horizontal.ParentId, QuestionId = horizontal.QuestionId, Text = horizontal.Text, Value = horizontal.Value });
                }
                else
                {
                    var tempHorizantal = dbQuestion.QuestionHorizontals.Where(x => x.Id == horizontal.Id).FirstOrDefault();
     
                    tempHorizantal.Index = horizontal.Index;
                    tempHorizantal.ParentId = horizontal.ParentId;
         
                    tempHorizantal.Text = horizontal.Text;
                    tempHorizantal.Value = horizontal.Value;
                }
            }

            foreach (var vertical in question.QuestionVerticals)
            {
                if (dbQuestion.QuestionVerticals.Where(x => x.Id == vertical.Id).Count() < 1)
                {
                    dbQuestion.QuestionVerticals.Add(new QuestionVertical() { Index = vertical.Index, ParentId = vertical.ParentId, QuestionId = vertical.QuestionId, Text = vertical.Text, Value = vertical.Value });
                }
                else
                {
                    var tempVertical = dbQuestion.QuestionVerticals.Where(x => x.Id == vertical.Id).FirstOrDefault();
               
                    tempVertical.Index = vertical.Index;
                    tempVertical.ParentId = vertical.ParentId;
             
                    tempVertical.Text = vertical.Text;
                    tempVertical.Value = vertical.Value;
                }
            }
            _repository.Update(dbQuestion);

        }

        /*  public List<Question> getAimList(int projectId)
          {
              return _repository.Table.Where(x => x.QuestionTextTypeId == ((int)EnumQuestionTextType.Amac) && x.ProjectId==projectId).ToList();
          }
        */

          public List<QuestionHorizontal> getTargetList(int questionId)
           {
            return _efQuestionHorizontalDal.getQuestionHorizontal(questionId);

            /*  List<Question> aimList = getAimList(projectId);
              List<int> aimIdList= aimList.Select(x => x.Id).Distinct().ToList();
              return _repository.Table.Where(x => x.QuestionTextTypeId == ((int)EnumQuestionTextType.Hedef) && aimIdList.Contains(x.ParentId) && x.ProjectId == projectId).ToList();
           */
          }

        public int addQuestionHorizontal(QuestionHorizontal questionHorizontal)
        {
            _efQuestionHorizontalDal.HorizantalInsert(questionHorizontal);
            return questionHorizontal.Id;

        }



        /*
         public List<Question> getProjectTargetList(int projectId)
         {
             return _repository.Table.Where(x => x.QuestionTextTypeId == ((int)EnumQuestionTextType.Amac)).ToList();
         }*/
    }
}
