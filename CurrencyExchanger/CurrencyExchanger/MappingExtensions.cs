using Business.Models;
using CurrencyExchanger.Models;

namespace CurrencyExchanger
{
    public static class MappingExtensions
    {
        public static CurrencyItemModel ToModel(this CurrencyItemDto dto)
        {
            return new CurrencyItemModel
            {
                Code = dto.Code,
                Name = dto.Name,
                RatePrimary = dto.RatePrimary,
                RateSecondary = dto.RateSecondary,
                Quantity = dto.Quantity,
            };
        }

        public static CurrencySettingsItemModel ToModel(this CurrencySettingsDto dto)
        {
            return new CurrencySettingsItemModel
            {
                Code = dto.Code,
                Name = dto.Name,
                IsActive = dto.IsActive,
            };
        }

        public static CurrencySettingsDto ToDto(this CurrencySettingsItemModel source)
        {
            return new CurrencySettingsDto
            {
                Code = source.Code,
                Name = source.Name,
                IsActive = source.IsActive,
            };
        }

    }
}
