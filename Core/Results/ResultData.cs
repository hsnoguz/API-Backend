using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class ResultData<T> :Result, IResultData<T>
    {
        public ResultData(T data,bool isValid,string message):base(isValid,message)
        {
            Data = data;
        }

        public ResultData(T data,bool isValid):base(isValid)
        {
            Data = data;
        }

        public ResultData(T data):base(true)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
