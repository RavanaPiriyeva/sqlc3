using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    internal class SameNameException:Exception
    {
        public SameNameException(string message):base(message)
        {

        }
    }
}
