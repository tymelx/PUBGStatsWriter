using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGStatsWriter.Models
{
    public class PUBGStats
    {
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Wins { get; set; }
        public double KillDeathRatio { get; set; }
        public DateTime LastKill { get; set; }
        public DateTime LastDeath { get; set; }
        public DateTime LastWin { get; set; }

        public PUBGStats()
        {
            this.LastKill = DateTime.UtcNow;
            this.LastDeath = DateTime.UtcNow;
            this.LastWin = DateTime.UtcNow;
        }
    }
}
