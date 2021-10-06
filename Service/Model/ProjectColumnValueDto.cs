using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class ProjectColumnValueDto : ICustomEntity
    {
        public int ProjectId { get; set; }
        public List<ColumnValue> ColumnValues { get; set; }
        public int SurveyId { get; set; }
    }
    public class ColumnValue {
        public string Key { get; set; }
        public string Value{ get; set; }
    }
}
