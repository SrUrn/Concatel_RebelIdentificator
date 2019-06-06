using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelIdentificator.Custom_Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base()
        {

        }

        public CustomException(string message) : base(message)
        {

        }
    }
}
