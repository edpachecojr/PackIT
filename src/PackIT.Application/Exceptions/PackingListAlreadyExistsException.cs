using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Application.Exceptions
{
    public class PackingListAlreadyExistsException : PackITException
    {
        public PackingListAlreadyExistsException(string name) : base($"Packing list with nam '{name}' already exists.")
        {
            Name = name;
        }

        public string Name { get; }
    }
}
