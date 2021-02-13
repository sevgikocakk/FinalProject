using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Remel voidler için başlangıc. 
    public interface IResult
    {
        bool Success { get; }//Get demek sadece okunabilir demek.
        string Message { get; }
    }
}
