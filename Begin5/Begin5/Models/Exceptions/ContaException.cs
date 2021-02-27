using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Exceptions
{
    public class ContaException : Exception
    {
        public ContaException()
        {
        }

        public ContaException(string message):base(message)
        {

        }

        
    }
}
