using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Service.Abstract
{
   public interface IRefreshTokenService
    {
        public bool getRefreshTokenControl(int userId, string token);
        public int Insert(int userId, string newToken);
    }
}
