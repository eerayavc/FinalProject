using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç ---{get;} => okumak için --- {set;} =>yazmak için
    public interface IResult
    {
        bool Success { get; }//bool --- true false 
        string Message { get; }
    }
}
