using Newtonsoft.Json;
using PUBGScreenCapper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGScreenCapper.Services
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
            catch (Exception)
            {

            }

            return applicationSettings;
        }

        public static void SaveApplicationSettings(ApplicationSettings applicationSettings)
        {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(applicationSettings));
        }
    }
}
