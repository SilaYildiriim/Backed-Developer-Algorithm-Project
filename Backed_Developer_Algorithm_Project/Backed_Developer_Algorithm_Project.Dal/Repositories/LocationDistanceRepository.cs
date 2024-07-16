using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.IRepositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.Repositories
{
    public class LocationDistanceRepository : ILocationDistanceRepository
    {
        public List<LocationDistance> GetAllLocationDistances()
        {
            return SeedData.LocationDistanceSeed.DurationBetweenLocationsMinutesMatrix;
        }
    }
}
