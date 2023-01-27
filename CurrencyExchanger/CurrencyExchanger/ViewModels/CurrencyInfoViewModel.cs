using CurrencyExchanger.Models;

namespace CurrencyExchanger.ViewModels
{
    public class CurrencyInfoViewModel : ViewModelBase
    {
        private readonly CurrencyItemModel _model;

        public string Code
        {
            get => _model.Code;
            set => _model.Code = value;
        }

        public string Name
        {
            get => _model.Name;
            set => _model.Name = value;
        }

        public int Quantity
        {
            get => _model.Quantity;
            set => _model.Quantity = value;
        }

        public double RateToday
        {
            get => _model.RatePrimary;
            set => _model.RatePrimary = value;
        }

        public double RateSecondary
        {
            get => _model.RateSecondary;
            set => _model.RateSecondary = value;
        }

        public CurrencyInfoViewModel(CurrencyItemModel model)
        {
            _model = model;
        }
    }
}
