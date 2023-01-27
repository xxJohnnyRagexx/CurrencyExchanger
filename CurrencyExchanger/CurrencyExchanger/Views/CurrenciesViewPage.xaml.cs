using CurrencyExchanger.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrencyExchanger.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrenciesViewPage : ContentPage
    {

        private CurrencyListViewModel _viewModel;
        public CurrenciesViewPage()
        {
            BindingContext = _viewModel = new CurrencyListViewModel(Navigation);
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }


    }
}