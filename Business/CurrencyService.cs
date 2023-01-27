using Business.Models;
using CurrencyHttpClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Business
{
    /// <summary>
    /// The currency service.
    /// </summary>
    public class CurrencyService
    {
        private readonly CurrencyClient _currencyClient;
        private readonly SettingsService _settingsService;
        public CurrencyService(CurrencyClient currencyClient, SettingsService settingsService)
        {
            _currencyClient = currencyClient;
            _settingsService = settingsService;
        }

        /// <summary>
        /// Gets currency rates for specified date and applies the settings for showing that.
        /// </summary>
        /// <param name="datePrimary">Specified date</param>
        /// <returns>List of currency rates for show.</returns>
        public CurrencyListDto GetCurrencies()
        {
            List<CurrencySettingsDto> settings;
            CurrencyListDto currencies = new CurrencyListDto
            {
                DatePrimary = DateTime.Now,
                DateSecondary = DateTime.Now.AddDays(1),
            };
            var currenciesListPrimary = _currencyClient.GetData(currencies.DatePrimary);
            var currenciesListSecondary = _currencyClient.GetData(currencies.DateSecondary);

            if (currenciesListPrimary.Date == currenciesListSecondary.Date)
            {
                currencies.DatePrimary = currencies.DatePrimary.AddDays(-1);
                currencies.DateSecondary = currencies.DateSecondary.AddDays(-1);
                currenciesListPrimary = _currencyClient.GetData(currencies.DatePrimary);
            }

            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SettingFile.json")))
                _settingsService.InitializeSettings(currencies);
            else
            {
                settings = _settingsService.GetCurrencySettings();
                currencies.СurrenciesList = currenciesListPrimary.ToDto().Where(x => settings.Any(y => y.Code == x.Code && y.IsActive)).ToList();
            }
            foreach (var item in currencies.СurrenciesList)
            {
                item.RateSecondary = currenciesListSecondary.Currencies.FirstOrDefault(x => x.Code == item.Code).Rate;
            }
            return currencies;

        }
    }
}
