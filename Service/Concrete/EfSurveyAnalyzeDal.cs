using DAL.Model;
using Microsoft.Data.SqlClient;
using Repository;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Concrete
{
    public class EfSurveyAnalyzeDal : IEfSurveyAnalyzeDal
    {
        ManagerContext _context;
        public IRepository<Question> _repositoryQuestion;
        public EfSurveyAnalyzeDal(ManagerContext context, IRepository<Question> repositoryQuestion)
        {
            _context = context;
            _repositoryQuestion = repositoryQuestion;
        }

        public async Task<List<AnalyzeDto>> getSwot(int projectId)
        {
       
            var questions = await _repositoryQuestion.GetSql($"sp_GetSwot {projectId}");
          
            var result= questions.ToList().Select(A=>new AnalyzeDto() {Id=A.Id,Soru=A.Text,Puan=A.Puan,Sonuc= A.Puan < 3.5m?"Zayıf":"Güçlü" }).ToList();
         return result;
        }
    }
}
