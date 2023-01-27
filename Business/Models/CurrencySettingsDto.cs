namespace Business.Models
{
    /// <summary>
    /// Represents the data transfer object for settings.
    /// </summary>
    public class CurrencySettingsDto
    {
        /// <summary>
        /// Gets or sets the code of currency.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the full name of currency.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value that means currency is active for show or not.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
