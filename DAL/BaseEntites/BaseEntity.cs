using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BaseEntites
{
    class BaseEntity
    {
    }

    public class ProductMetaData
    {
        [SetCurrentDate]
        public string UpdateDate { get; set; }
    }

    public class DefaultInsertTimeMetaData
    {
        [SetCurrentDate]
        public string InsertTime { get; set; }
    }
}
