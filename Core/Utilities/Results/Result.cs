using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success)
        {
            Message = message;                                 //Constructor can set by readonly properties
        }

        public Result(bool success)
        {
            Success = success;                                 
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
