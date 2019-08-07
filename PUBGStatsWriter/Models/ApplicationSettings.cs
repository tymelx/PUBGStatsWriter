using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGStatsWriter.Models
{
    public class ApplicationSettings
    {
        public string OutputDirectory { get; set; }
        public string ScreenshotDirectory { get; set; }

        public bool TotalKills { get; set; }
        public bool TotalDeaths { get; set; }
        public bool TotalGamesPlayed { get; set; }
        public bool KillDeathRatio { get; set; }
        public bool TotalWins { get; set; }

        public string TotalKillsFilePath
        {
            get
            {
                return String.IsNullOrEmpty(this.OutputDirectory)
                    ? "total_kills.txt"
                    : String.Format("{0}\\total_kills.txt", this.OutputDirectory);
            }
        }

        public string TotalDeathsFilePath
        {
            get
            {
                return String.IsNullOrEmpty(this.OutputDirectory)
                    ? "total_deaths.txt"
                    : String.Format("{0}\\total_deaths.txt", this.OutputDirectory);
            }
        }

        public string KillDeathRatioFilePath
        {
            get
            {
                return String.IsNullOrEmpty(this.OutputDirectory)
                    ? "kd_ratio.txt"
                    : String.Format("{0}\\kd_ratio.txt", this.OutputDirectory);
            }
        }

        public string TotalWinsFilePath
        {
            get
            {
                return String.IsNullOrEmpty(this.OutputDirectory)
                    ? "total_wins.txt"
                    : String.Format("{0}\\total_wins.txt", this.OutputDirectory);
            }
        }

        public ApplicationSettings()
        {
            this.TotalKills = true;
            this.KillDeathRatio = true;
            this.TotalWins = true;
            this.TotalDeaths = true;
        }
    }
}
