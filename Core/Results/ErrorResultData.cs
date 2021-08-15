using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class ErrorResultData<T> :ResultData<T>
    {
        public ErrorResultData(T data,string message):base(data,false,message)
        {
        
        }

        public ErrorResultData(T data):base(data,false)
        {
        
        }

        public ErrorResultData(string message):base(default,false,message)
        {
        
        }

        public ErrorResultData() : base(default, false)
        {

        }
    }
}
