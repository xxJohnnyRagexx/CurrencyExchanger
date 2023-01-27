namespace Storage.Entities
{
    public class CurrencySettingsEntity
    {
        /// <summary>
        /// Gets or sets the short name of currency.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the name of currency.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the value that describes currency will be showed or not.
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
}
