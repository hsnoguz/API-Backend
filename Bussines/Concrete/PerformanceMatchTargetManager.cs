﻿using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class PerformanceMatchTargetManager : IPerformanceMatchTarget
    {
        IEfPerformanceMatchTargetDal _efPerformanceMatchTargetDal;

        IAuthService _authService;
        public PerformanceMatchTargetManager(IEfPerformanceMatchTargetDal efPerformanceMatchTargetDal, IEfOrganizationServiceDal efOrganizationServiceDal, IAuthService authService)
        {
            _efPerformanceMatchTargetDal = efPerformanceMatchTargetDal;

            _authService = authService;
        }

        public IResult InsertPerformanceMatch(DAL.Model.PerformanceMatchTarget performanceMatch)
        {
            try
            {
                _efPerformanceMatchTargetDal.InsertPerformanceMatch(performanceMatch);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
       
        }

        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatch(string roleName,int userId)
        {
           int organizationId= _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformanceMatchDto>>(_efPerformanceMatchTargetDal.ListPerformanceMatch(roleId, organizationId));
        }

        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatchAction(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformanceMatchDto>>(_efPerformanceMatchTargetDal.ListPerformanceMatchAction(roleId, organizationId));
        }

        public IResultData<List<PerformancePeriotMatchDto>> ListPerformanceMatchPeriotAction(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformancePeriotMatchDto>>(_efPerformanceMatchTargetDal.ListPerformanceMatchPeriotAction(roleId, organizationId));
        }

        public IResultData<List<PerformancePeriotMatchDto>> ListPerformanceMatchPeriotSubAction(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformancePeriotMatchDto>>(_efPerformanceMatchTargetDal.ListPerformanceMatchPeriotSubAction(roleId, organizationId));
        }

        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatchSubAction(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformanceMatchDto>>(_efPerformanceMatchTargetDal.ListPerformanceMatchSubAction(roleId, organizationId));
        }

        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatchTarget(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformanceMatchDto>>(_efPerformanceMatchTargetDal.ListPerformanceMatchTarget(roleId, organizationId));
        }

        public IResultData<List<PerformancePeriotMatchDto>> ListPerformancePeriotMatchTarget(string roleName, int userId)
        {
            int organizationId = _authService.CurrentOrganizationId(userId).Data;
            int roleId = _authService.getRoleId(roleName).Data;
            return new SuccessResultData<List<PerformancePeriotMatchDto>>(_efPerformanceMatchTargetDal.ListPerformancePeriotMatchTarget(roleId, organizationId));
        }

        public IResultData<List<Match>> MatchList()
        {
            return new SuccessResultData<List<Match>>(_efPerformanceMatchTargetDal.MatchList());
        }
    }
}