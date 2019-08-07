using PUBGStatsWriter.Models;
using System;
using System.Collections.Generic;
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
            return applicationSettings;
        }

        /// <summary>
        /// Will read in an image and analyze the data. Image analysis will tell any of the following things:
        /// New kill (dont register the same kill twice)
        /// New death (dont register the same death twice)
        /// Game won (dont register the same game win twice)
        /// </summary>
        public static void AnalyzeScreenshot()
        {

        }
    }
}
