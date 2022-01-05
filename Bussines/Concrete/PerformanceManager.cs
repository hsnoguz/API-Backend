using Bussines.Abstract;
using Bussines.Service.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class PerformanceManager : IPerformanceManager
    {
        IEfPerformanceDal _efPerformanceDal;
        IPerformanceAimService _performanceAimService;
        IPerformancePeriotService _performancePeriotService;
        IPerformanceTypeService  _performanceTypeService;
        IPeriotManager _periotManager;
        IAuthService _authManager;
        IOrganizationService _organization;

        public PerformanceManager(IEfPerformanceDal efPerformanceDal,
                IOrganizationService organization,
                IPerformanceAimService PerformanceAimService,
                IPerformancePeriotService PerformancePeriotService,
                IPerformanceTypeService PerformanceTypeService,
                IPeriotManager periotManager,
                IAuthService authManager
            )
        {
            _efPerformanceDal = efPerformanceDal;
            _organization = organization;
            _performanceAimService = PerformanceAimService;
            _performancePeriotService = PerformancePeriotService;
            _performanceTypeService = PerformanceTypeService;
            _periotManager = periotManager;
            _authManager = authManager;
        }
        public IResult InsertPerformance(Performance Performance)
        {
            try
            {
                _efPerformanceDal.InsertPerformance(Performance);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message); 
            }
         
 
      
        }

        public IResult DeletePerformance(int Id)
        {
            try
            {
                _efPerformanceDal.DeletePerformance(Id);
                return new SuccessResult();
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }


        public IResultData<List<Organization>> Organizationlist()
        {
            return new SuccessResultData<List<Organization>>(_organization.OrganizationList());
        }

        public IResultData<List<PerformanceAim>> PerformanceAimList()
        {
            return _performanceAimService.PerformanceAimList();
        }

        public IResultData<List<PerformancePeriot>> PerformancePeriotList()
        {
            return _performancePeriotService.PeriotList();
        }

        public IResultData<List<PerformanceType>> PerformanceTypeList()
        {
            return _performanceTypeService.PerformanceTypeList();
        }

        public IResultData<Periot> CurrentPeriot(int Id)
        {
            return _periotManager.currentPeriot(Id);
        }

        public IResultData<List<Performance>> PerformanceList(int userId,string roleName)
        {
            int roleId = _authManager.getRoleId(roleName).Data;
            return new SuccessResultData<List<Performance>>(_efPerformanceDal.PerformanceList(_authManager.CurrentOrganizationId(userId).Data, roleId));
        }

        public IResultData<List<Performance>> PerformanceTargetList(int userId, string roleName)
        {
            int roleId = _authManager.getRoleId(roleName).Data;
            return new SuccessResultData<List<Performance>>(_efPerformanceDal.PerformancePeriotList(_authManager.CurrentOrganizationId(userId).Data, roleId));
        }

        public IResultData<List<Performance>> PerformanceTarget(int PerformanceId)
        {
            return new SuccessResultData<List<Performance>>(_efPerformanceDal.PerformancePeriot(PerformanceId));
        }

        public IResult EditPerformanceType(PerformanceType performanceType)
        {
            return _performanceTypeService.EditPerformanceType(performanceType);
        }

        public IResult InsertPerformanceType(PerformanceType performanceType)
        {
            return _performanceTypeService.InsertPerformanceType(performanceType);
        }
    }
}
