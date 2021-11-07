﻿using Bussines.Service.Abstract;
using Core.Results;
using DAL.Model;
using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Concrete
{
    public class PerformanceTypeService : IPerformanceTypeService
    {
        public IEfPerformanceTypeDal _efPerformanceTypeDal;
        public PerformanceTypeService(IEfPerformanceTypeDal efPerformanceTypeDal)
        {
            _efPerformanceTypeDal = efPerformanceTypeDal;
         }
        public IResultData<List<PerformanceType>> PerformanceTypeList()
        {
            return new SuccessResultData<List<PerformanceType>>(_efPerformanceTypeDal.PerformanceTypeList());
        }
    }
}
