using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exceptions
{
    internal class NotFoudException:Exception
    {
        public NotFoudException(string message):base(message)
        {

        }

    }
}
