using CurrencyExchanger.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrencyExchanger.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsViewPage : ContentPage
    {
        public SettingsViewPage()
        {
            BindingContext = new CurrencySettingsViewModel(Navigation);
            InitializeComponent();
        }

        private void Switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}