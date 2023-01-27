using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurrencyHttpClient.Models
{
    public class CurrencyClientResponse
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the list of currency rates.
        /// </summary>
        [JsonPropertyName("currencies")]
        public ICollection<CurrencyItem> Currencies { get; set; }
    }
}
