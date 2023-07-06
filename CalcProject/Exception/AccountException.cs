using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.Exception
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base (message){ }
    }
}
