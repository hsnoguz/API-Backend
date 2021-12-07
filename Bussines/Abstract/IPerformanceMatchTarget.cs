﻿using Core.Results;
using DAL.Model;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
  public  interface IPerformanceMatchTarget
    {
        public IResult InsertPerformanceMatch(PerformanceMatchTarget performanceMatch);
        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatch(string roleName,int userId);
        public IResultData<List<Match>> MatchList();
        public IResultData<List<Match>> MatchPriceList();

        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatchTarget(string roleName, int userId);
        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatchAction(string roleName, int userId);
        public IResultData<List<PerformanceMatchDto>> ListPerformanceMatchSubAction(string roleName, int userId);
        public IResultData<List<PerformancePeriotMatchDto>> ListPerformancePeriotMatchTarget(string roleName, int userId);
        public IResultData<List<PerformancePeriotMatchDto>> ListPerformanceMatchPeriotAction(string roleName, int userId);
        public IResultData<List<PerformancePeriotMatchDto>> ListPerformanceMatchPeriotSubAction(string roleName, int userId);
    }
}
