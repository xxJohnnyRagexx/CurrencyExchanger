using Storage.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Storage
{
    /// <summary>
    /// The repository of settings, which contained in json file.
    /// </summary>
    public class SettingsRepository
    {
        private readonly string settingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SettingFile.json");

        /// <summary>
        /// Gets the settings from JSON file.
        /// </summary>
        /// <returns>List of setting parameters for every currency.</returns>
        public List<CurrencySettingsEntity> GetSettings()
        {
            return JsonSerializer.Deserialize<List<CurrencySettingsEntity>>(
                File.ReadAllText(settingsFile)
                );
        }

        /// <summary>
        /// Sets settings to JSON file.
        /// </summary>
        /// <param name="settings">List of settings for every currency.</param>
        public void SetSettings(List<CurrencySettingsEntity> settings)
        {
            string jsonSettings = JsonSerializer.Serialize(settings);
            File.WriteAllText(settingsFile, jsonSettings);

        }
    }
}
