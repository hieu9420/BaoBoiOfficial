using System;
using System.Collections.Generic;
using System.Text;

namespace BaoBoi.Utilities.Exceptions
{
    public class BaoBoiException : Exception
    {
        public BaoBoiException()
        {
        }

        public BaoBoiException(string message)
            : base(message)
        {
        }

        public BaoBoiException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
