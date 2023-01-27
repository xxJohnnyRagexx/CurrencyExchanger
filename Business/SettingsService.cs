using Business.Models;
using Storage;
using System.Collections.Generic;

namespace Business
{
    /// <summary>
    /// Service of settings.
    /// </summary>
    public class SettingsService
    {
        private readonly SettingsRepository _settingsRepository;
        public SettingsService()
        {
            _settingsRepository = new SettingsRepository();
        }

        /// <summary>
        /// Gets settings.
        /// </summary>
        /// <returns>List of settings in dto.</returns>
        public List<CurrencySettingsDto> GetCurrencySettings()
        {
            return _settingsRepository.GetSettings().ToDto();
        }

        /// <summary>
        /// Initializes settings for currencies.
        /// </summary>
        /// <param name="source">List of currencies.</param>
        public void InitializeSettings(CurrencyListDto source)
        {
            _settingsRepository.SetSettings(source.ToStorageEntity());
        }

        /// <summary>
        /// Sets settings for currencies.
        /// </summary>
        /// <param name="source">List of currencies.</param>
        public void SetCurrencySettings(List<CurrencySettingsDto> source)
        {
            _settingsRepository.SetSettings(source.ToStorageEntity());
        }
    }
}
