using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class Result : IResult
    {
        public Result(bool isValid,string message):this(isValid)
        {
            Message = message;
        }

        public Result(bool isValid)
        {
            IsValid = isValid;
        }

        public bool IsValid { get; }
        public string Message { get; }
    }
}
