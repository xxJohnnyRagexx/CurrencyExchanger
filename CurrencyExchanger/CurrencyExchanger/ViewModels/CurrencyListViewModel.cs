using Business;
using CurrencyExchanger.Views;
using CurrencyHttpClient;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CurrencyExchanger.ViewModels
{
    public class CurrencyListViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }
        public DateTime DatePrimary { get; private set; }
        public DateTime DateSecondary { get; private set; }
        public ObservableCollection<CurrencyInfoViewModel> Currencies { get; private set; }
        public ICommand OpenSettingsCommand { get; private set; }

        private readonly CurrencyService _currencyService = new CurrencyService(
            new CurrencyClient(),
            new SettingsService());

        public CurrencyListViewModel(INavigation navigation)
        {
            OpenSettingsCommand = new Command(() => OpenSettingsView());
            Navigation = navigation;

            var data = _currencyService.GetCurrencies();
            DatePrimary = data.DatePrimary;
            DateSecondary = data.DateSecondary;

            Currencies = new ObservableCollection<CurrencyInfoViewModel>(
                data.СurrenciesList.Select(q => new CurrencyInfoViewModel(
                    q.ToModel()
                    )
                )
            );
        }

        private async void OpenSettingsView()
        {
            await Navigation.PushAsync(new SettingsViewPage());
        }

        public void OnAppearing()
        {
            var data = _currencyService.GetCurrencies();
            DatePrimary = data.DatePrimary;
            DateSecondary = data.DateSecondary;

            var list = data.СurrenciesList.Select(q => new CurrencyInfoViewModel(
                    q.ToModel()
                    )
            ).ToList();

            Currencies.Clear();
            foreach (var item in list) Currencies.Add(item);
        }
    }
}
