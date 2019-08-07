using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGStatsWriter.Models
{
    public class ApplicationSettings
    {
        public string PUBGName { get; set; }
        public string OutputDirectory { get; set; }
        public string ScreenshotDirectory { get; set; }

        public bool TotalKills { get; set; }
        public bool TotalDeaths { get; set; }
        public bool TotalGamesPlayed { get; set; }
        public bool KillDeathRatio { get; set; }
        public bool TotalWins { get; set; }

        public ApplicationSettings()
        {
            this.TotalKills = true;
            this.KillDeathRatio = true;
            this.TotalWins = true;
        }
    }
}
