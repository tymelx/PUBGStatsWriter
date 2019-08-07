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
        public double KillDeathRatio { get; set; }
        public int LastTotalKills { get; set; }
        public DateTime LastDeath { get; set; }
    }
}
