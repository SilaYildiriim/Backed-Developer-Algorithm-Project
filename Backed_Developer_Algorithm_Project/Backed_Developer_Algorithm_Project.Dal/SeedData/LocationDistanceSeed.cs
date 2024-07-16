using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.SeedData
{
    public class LocationDistanceSeed
    {
        public static List<LocationDistance> DurationBetweenLocationsMinutesMatrix = new List<LocationDistance>
        {
        new LocationDistance("A", "B", TimeSpan.Parse("15")),
        new LocationDistance("A", "C", TimeSpan.Parse("20")),
        new LocationDistance("A", "D", TimeSpan.Parse("10")),
        new LocationDistance("B", "C", TimeSpan.Parse("5")),
        new LocationDistance("B", "D", TimeSpan.Parse("25")),
        new LocationDistance("C", "D", TimeSpan.Parse("25"))
        };
    }
}
