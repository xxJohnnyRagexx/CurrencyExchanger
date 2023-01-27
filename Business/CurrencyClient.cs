using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Represents the currencies http client.
    /// </summary>
    public class CurrencyClient
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public CurrencyClient()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Gets the data about currencies for specified date.
        /// </summary>
        /// <param name="date">date for currency request.</param>
        /// <returns>list of currencies with data about their exchange rates.</returns>
        public CurrencyListDto GetData(DateTime date)
        {
            var data = _httpClient.GetStringAsync(buildUrl(date)).Result;
            return JsonSerializer.Deserialize<List<CurrencyListDto>>(data).FirstOrDefault();
        }

        private static string buildUrl(DateTime date)
        {
            return string.Format($"{Constants.GeorgianCurrencyRateBaseAdress}?date={date.ToString("dd.MM.yyyy")}");
        }
    }
}
