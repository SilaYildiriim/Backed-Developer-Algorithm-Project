using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites
{
    public class LocationDistance
    {
        public string From { get; set; }
        public string To { get; set; }
        public int DurationMinutes { get; set; }

        public LocationDistance(string from, string to, int durationMinutes)
        {
            From = from;
            To = to;
            DurationMinutes = durationMinutes;
        }
    }

}
