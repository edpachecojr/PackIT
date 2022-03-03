using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException : PackITException
    {
        public PackingItemAlreadyExistsException(string listName, string itemName)
            : base($"Packing list: '{listName}' already defined item '{itemName}'")
        {
        }
    }
}
