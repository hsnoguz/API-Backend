﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
  public  class AccessToken
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Expiration { get; set; }
        public string RefreshToken { get; set; }
        public int PeriotId { get; set; }
    }
}
