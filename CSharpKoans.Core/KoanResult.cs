using System;

namespace CSharpKoans.Core
{
    public abstract class KoanResult
    {

        //        type KoanResult = 
        //    | Success of string
        //    | Failure of string * Exception
        //with
        //    member this.Message =
        //        match this with
        //        | Success x -> x
        //        | Failure (x, _) -> x


        public string Message { get; set; }

    }

    public class Success : KoanResult
    {
        public Success(string successMessage)
        {
            Message = successMessage;
        }
    }

    public class Failure : KoanResult
    {
        public Exception Exception { get; set; }
        public Failure(string failureMessage, Exception e)
        {
            Message = failureMessage;
            Exception = e;
        }
    }
}
