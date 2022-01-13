using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
public  class ProjectSetting
    {
        public int Id { get; set; }
        public int projectID { get; set; }
        public string SettingName{ get; set; }
        public string SettingValue { get; set; }
        public DateTime? InsertTime { get; set; }

    }
}
