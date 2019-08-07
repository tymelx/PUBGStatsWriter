using Newtonsoft.Json;
using PUBGStatsWriter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGStatsWriter.Services
{
    public static class SettingsService
    {
        /// <summary>
        /// Loads in the user defined settings
        /// If no settings exist (first load) the text file is created
        /// </summary>
        /// <returns></returns>
        public static ApplicationSettings GetApplicationSettings()
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();

            try
            {
                using (StreamReader r = new StreamReader("settings.json"))
                {
                    string json = r.ReadToEnd();
                    applicationSettings = JsonConvert.DeserializeObject<ApplicationSettings>(json);
                }
            }
            catch(Exception)
            {

            }

            return applicationSettings;
        }

        public static void SaveApplicationSettings(ApplicationSettings applicationSettings)
        {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(applicationSettings));
        }

        public static void WriteStatsToFiles(ApplicationSettings applicationSettings, PUBGStats stats)
        {
            File.WriteAllText(applicationSettings.TotalKillsFilePath, stats.Kills.ToString());
            File.WriteAllText(applicationSettings.TotalDeathsFilePath, stats.Deaths.ToString());
            File.WriteAllText(applicationSettings.KillDeathRatioFilePath, stats.KillDeathRatio.ToString());
            File.WriteAllText(applicationSettings.TotalWinsFilePath, stats.Wins.ToString());
        }
    }
}
