using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    internal class NegativeNumberException:Exception
    {
        public NegativeNumberException(string message):base(message)
        {

        }
    }
}
