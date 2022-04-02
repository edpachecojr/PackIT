using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Application.Exceptions
{
    public class MissingLocalizationWeatherException : PackItException
    {
        public MissingLocalizationWeatherException(Localization localization) : base($"Couldn't fetch weather data for localization '{localization.Country}/{localization.City}'.")
        {
            Localization = localization;
        }

        public Localization Localization { get; }
    }
}
