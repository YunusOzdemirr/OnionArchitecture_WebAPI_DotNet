using System;
using System.Runtime.Serialization;

namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
        public ValidationException() : this("Validation error occured")
        {
        }
        public ValidationException(Exception ex):this(ex.Message)
        {
        }
    }
}

