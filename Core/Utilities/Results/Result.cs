using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //ctorumuz iki tane parametre istiyor.
        //Get'ler read onlydir ama readonlyliler ctorda set edilebilir.
        //this demek classın kendisi demek yani resultı kast ediyor.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success) //ctor overloading.
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
