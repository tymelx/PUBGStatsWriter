using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBGScreenCapper.Models
{
    public class ApplicationSettings
    {
        public string OutputDirectory { get; set; }
        public int Interval { get; set; }

        public ApplicationSettings()
        {
            this.OutputDirectory = String.Empty;
            this.Interval = 1000;
        }
    }
}
