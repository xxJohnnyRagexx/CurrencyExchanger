namespace CurrencyExchanger.Models
{
    /// <summary>
    /// Represents the model of currency.
    /// </summary>
    public class CurrencyItemModel
    {
        /// <summary>
        /// Gets or sets the code of currency.
        /// </summary>
        
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the name of currency.
        /// </summary>
        
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the rate of currency for specified quantity.
        /// </summary>
        public double RatePrimary { get; set; }

        /// <summary>
        /// Gets or sets the rate of currency for specified quantity.
        /// </summary>
        public double RateSecondary { get; set; }
    }
}
