using System;
using System.Collections.Generic;
using System.Text;

namespace Aircoin
{
    public class NotValidAmountException : ApplicationException
    {
        public NotValidAmountException(string message) : base(message)
        {
        
        }
    }
}
