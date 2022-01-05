using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
    public interface IEfPerformanceDal
    {
        public void InsertPerformance(Performance indicator);
        public List<Performance> PerformanceList(int organizationId,int roleId);
        public List<Performance> PerformancePeriotList(int organizationId, int roleId);
        public Performance getPerformance(int Id);
        public List<Performance> PerformancePeriot(int indicatorId);
        public void DeletePerformance(int performanceId);
    }
}
