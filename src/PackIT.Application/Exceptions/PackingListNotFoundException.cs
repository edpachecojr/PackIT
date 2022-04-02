using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Application.Exceptions
{
    public class PackingListNotFoundException : PackItException
    {
        public PackingListNotFoundException(Guid id) : base($"Packing list '{id}' was not found.")
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
