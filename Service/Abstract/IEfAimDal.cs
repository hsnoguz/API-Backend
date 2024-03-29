﻿using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstract
{
 public  interface IEfAimDal
    {
        public List<Aim> AimList(int periotId);

        public List<Aim> FullPlan(int periotId);
        public void EditAim(int Id,string explanation);

        public void AddAim( Aim aim);
        public void DeleteAim(int id);
        
    }
}
