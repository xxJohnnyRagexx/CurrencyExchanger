using System;
using System.Collections.Generic;

namespace Business.Models
{
    /// <summary>
    /// Represents the data transfer object.
    /// </summary>
    public class CurrencyListDto
    {
        /// <summary>
        /// Gets or sets the yesterday's or today's date.
        /// </summary>
        public DateTime DatePrimary { get; set; }

        /// <summary>
        /// Gets or sets the today's or yesterday's date.
        /// </summary>
        public DateTime DateSecondary { get; set; }

        /// <summary>
        /// Gets or sets the list of currency rates for primary and secondary dates.
        /// </summary>
        public ICollection<CurrencyItemDto> СurrenciesList { get; set; }
    }
}
