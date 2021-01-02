using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6.Exceptions
{
    class CustomException : Exception
    {
        public string ErrorClass { get; set; }
        public CustomException(string message, string errorClass)
            : base(message)
        {
            this.ErrorClass = errorClass;
        }
    }
}