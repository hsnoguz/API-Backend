﻿using Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class UserForLoginDto: ICustomEntity

    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int PeriotId { get; set; }
    }
}
