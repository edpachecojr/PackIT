using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class InvalidTemperatureException : PackItException
    {
        public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid temperature.")
        {
            Value = value;
        }

        public double Value { get; }
    }
}
