using System;
using System.Text.Json.Serialization;

namespace CurrencyHttpClient.Models
{
    /// <summary>
    /// Represents the currency exchange rate info.
    /// </summary>
    public class CurrencyItem
    {
        /// <summary>
        /// Gets or sets the currency code (or Short Name).
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets quantity of currency.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets formatted rate.
        /// </summary>
        [JsonPropertyName("rateFormated")]
        public string RateFormated { get; set; }

        /// <summary>
        /// Gets or sets formatted difference.
        /// </summary>
        [JsonPropertyName("diffFormated")]
        public string DiffFormated { get; set; }

        /// <summary>
        /// Gets or sets rate.
        /// </summary>
        [JsonPropertyName("rate")]
        public double Rate { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the difference.
        /// </summary>
        [JsonPropertyName("diff")]
        public double Diff { get; set; }

        /// <summary>
        /// Gets or sets date.
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the date in valid form.
        /// </summary>
        [JsonPropertyName("validFromDate")]
        public DateTime ValidFromDate { get; set; }
    }
}
