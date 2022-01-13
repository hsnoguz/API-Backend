using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
   public interface ISurveyAnalzeManager
    {
        public Task<List<AnalyzeDto>> getSwot(int projectId);
    }
}
