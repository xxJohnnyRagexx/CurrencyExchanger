namespace Business.Models
{
    /// <summary>
    /// Represents the currency exchange rate info.
    /// </summary>
    public class CurrencyItemDto
    {
        /// <summary>
        /// Gets or sets the currency code (or Short Name).
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets quantity of currency.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the rate of currency for primary date.
        /// </summary>
        public double RatePrimary { get; set; }

        /// <summary>
        /// Gets or sets the rate of currency for secondary date.
        /// </summary>
        public double RateSecondary { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        public string Name { get; set; }
    }
}
