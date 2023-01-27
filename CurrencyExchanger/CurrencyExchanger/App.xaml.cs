using CurrencyExchanger.ViewModels;
using CurrencyExchanger.Views;
using System;
using Xamarin.Forms;

namespace CurrencyExchanger
{
    public partial class App : Application
    {
        public static CurrencyListViewModel MainViewModel { get; private set; }
        public App()
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            InitializeComponent();
            MainPage = new NavigationPage(new CurrenciesViewPage());
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MainPage = new ErrorViewPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
