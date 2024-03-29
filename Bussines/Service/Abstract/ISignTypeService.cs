﻿using Bussines.Abstract;
using Core.Results;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
    public interface ISignTypeManager : IListService<PerformanceType>
    {
        public IResult UpdateSignType(int id, string explanation);
    }
}
