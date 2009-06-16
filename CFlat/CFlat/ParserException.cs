using System;

namespace CFlat
{
    public class ParserException : Exception
    {
        public ParserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ParserException()
        {
        }
    }
}