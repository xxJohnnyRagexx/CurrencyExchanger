using CurrencyExchanger.Models;

namespace CurrencyExchanger.ViewModels
{
    public class CurrencySettingsItemViewModel : ViewModelBase
    {
        private CurrencySettingsItemModel _model;

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
        public bool IsActive
        {
            get => _model.IsActive;
            set => _model.IsActive = value;
        }
        public CurrencySettingsItemViewModel(
            CurrencySettingsItemModel model)
        {
            _model = model;
        }
    }
}
