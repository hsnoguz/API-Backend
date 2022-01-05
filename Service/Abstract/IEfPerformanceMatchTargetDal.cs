using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
  public interface IEfPerformanceMatchTargetDal
    {
        public void InsertPerformanceMatch(PerformanceMatchTarget performanceMatch);
        public List<PerformanceMatchDto> ListPerformanceMatch(int roleId,int organizationId,int periotId);
        public List<PerformanceMatchDto> ListPerformanceMatchTarget(int roleId, int organizationId, int periotId);
        public List<PerformanceMatchDto> ListPerformanceMatchAction(int roleId, int organizationId, int periotId);
        public List<PerformanceMatchDto> ListPerformanceMatchSubAction(int roleId, int organizationId, int periotId);

        public List<PerformancePeriotMatchDto> ListPerformancePeriotMatchTarget(int roleId, int organizationId, int periotId);
        public List<PerformancePeriotMatchDto> ListPerformancePeriotMatchTargetSingle(int performanceId);
        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotAction(int roleId, int organizationId, int periotId);
        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotActionSingle(int actionId);
        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotSubAction(int roleId, int organizationId, int periotId);
        public List<PerformancePeriotMatchDto> ListPerformanceMatchPeriotSubActionSingle(int subActionId);
        public void EditOrganizationId(int matchId, int targetId, int organizationId);
        public List<Match> MatchList();
        public List<Match> MatchPriceList();
    }
}
