using Business.Models;
using CurrencyHttpClient.Models;
using Storage.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    /// <summary>
    /// Mapping extensions.
    /// </summary>
    internal static class MappingExtensions
    {
        /// <summary>
        /// Maps source from dto to entity.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>List of settings entities.</returns>
        public static List<CurrencySettingsEntity> ToStorageEntity(this CurrencyListDto source)
        {
            return source.СurrenciesList.Select(x =>
                new CurrencySettingsEntity
                {
                    Code = x.Code,
                    Name = x.Name,
                }
            ).ToList();
        }

        /// <summary>
        /// Maps source from dto to entity.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>List of settings entities.</returns>
        public static List<CurrencySettingsEntity> ToStorageEntity(this List<CurrencySettingsDto> source)
        {
            return source.Select(x =>
                new CurrencySettingsEntity
                {
                    Code = x.Code,
                    Name = x.Name,
                    IsActive = x.IsActive,
                }
            ).ToList();
        }

        /// <summary>
        /// Maps source from entity to dto.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>List of dtos.</returns>
        public static List<CurrencySettingsDto> ToDto(this List<CurrencySettingsEntity> source)
        {
            return source.Select(x =>
                new CurrencySettingsDto
                {
                    Code = x.Code,
                    Name = x.Name,
                    IsActive = x.IsActive,
                }
            ).ToList();
        }

        /// <summary>
        /// Maps source from entity to dto.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>List of dtos.</returns>
        public static List<CurrencyItemDto> ToDto(this CurrencyClientResponse source)
        {
            return source.Currencies.Select(x => new CurrencyItemDto
            {
                Code = x.Code,
                Name = x.Name,
                Quantity = x.Quantity,
                RatePrimary = x.Rate,
            }
            ).ToList();
        }
    }
}
