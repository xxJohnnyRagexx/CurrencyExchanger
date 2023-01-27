using Business;
using CurrencyExchanger.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CurrencyExchanger.ViewModels
{
    public class CurrencySettingsViewModel
    {
        public ICommand SaveCommand { get; private set; }
        public ICommand UpdateView { get; private set; }
        public IList<CurrencySettingsItemModel> CurrencySettings { get; private set; }
        private INavigation _navigation;
        private SettingsService _settingsService = new SettingsService();

        public CurrencySettingsViewModel(INavigation navigation)
        {
            CurrencySettings = new ObservableCollection<CurrencySettingsItemModel>(
                _settingsService.GetCurrencySettings().Select(
                    q => q.ToModel())
                );
            SaveCommand = new Command(SaveCommandExecute, SaveCommandCanExecute);
            _navigation = navigation;
        }
        private async void SaveCommandExecute()
        {
            _settingsService.SetCurrencySettings(CurrencySettings.Select(
                x => x.ToDto()).ToList());
            await _navigation.PopAsync();
        }
        private bool SaveCommandCanExecute()
        {
            return true;
        }
    }
}
