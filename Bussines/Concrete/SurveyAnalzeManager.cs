using Bussines.Abstract;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class SurveyAnalzeManager : ISurveyAnalzeManager
    {
        IEfSurveyAnalyzeDal _efSurveyAnalyzeDal;

        public SurveyAnalzeManager(IEfSurveyAnalyzeDal efSurveyAnalyzeDal)
        {
            _efSurveyAnalyzeDal = efSurveyAnalyzeDal;
        }
        public async Task<List<AnalyzeDto>> getSwot(int projectId)
        {
            return await _efSurveyAnalyzeDal.getSwot(projectId);
        }
    }
}
