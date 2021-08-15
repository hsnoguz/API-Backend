using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class SuccessResult:Result 
    {
        public SuccessResult(bool isValid,string message):base(isValid,message)
        {

        }

        public SuccessResult(bool isValid) : base(isValid)
        {

        }
    }
}
