using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
   public class SuccessResultData<T> :ResultData<T>
    {
        public SuccessResultData(T data,string message):base(data,true,message)
        {
        
        }

        public SuccessResultData(T data):base(data,true)
        {
        
        }

        public SuccessResultData(string message):base(default,true,message)
        {
        
        }

        public SuccessResultData() : base(default, true)
        {

        }
    }
}
