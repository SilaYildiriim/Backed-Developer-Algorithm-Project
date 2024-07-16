using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.SeedData
{
    public class LocationDistanceSeed
    {
        public static List<LocationDistance> DurationBetweenLocationsMinutesMatrix = new List<LocationDistance>
    {
        new LocationDistance("A", "B", 15),
        new LocationDistance("A", "C", 20),
        new LocationDistance("A", "D", 10),
        new LocationDistance("B", "C", 5),
        new LocationDistance("B", "D", 25),
        new LocationDistance("C", "D", 25)
    };
    }
}
