using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public interface IEfSurveyAnalyzeDal
    {
        public Task<List<AnalyzeDto>> getSwot(int projectId);
    }
}
