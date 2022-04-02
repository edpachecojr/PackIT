using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Exceptions
{
    public abstract class PackItException : Exception
    {
        protected PackItException(string message) : base(message)
        { }
    }
}
