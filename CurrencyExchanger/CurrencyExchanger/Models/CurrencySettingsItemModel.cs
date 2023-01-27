namespace CurrencyExchanger.Models
{
    /// <summary>
    /// Represents the settings model.
    /// </summary>
    public class CurrencySettingsItemModel
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
        /// Gets or sets the value which describes, will be currency showed or not.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
