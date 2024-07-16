using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.IRepositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService;
using Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.Service
{
    public class LocationDistanceService : ILocationDistanceService
    {
        private readonly ILocationDistanceRepository _locationDistanceRepository;

        public LocationDistanceService(ILocationDistanceRepository locationDistanceRepository)
        {
            _locationDistanceRepository = locationDistanceRepository;
        }

        public bool IsLocationTravelExceedLimit(string location, List<int> scheduledEventIds, List<LocationDistance> locationDistances, List<Event> allEvents)
        {
            var allLocationDistances = _locationDistanceRepository.GetAllLocationDistances();

            foreach (var eventId in scheduledEventIds)
            {
                var duration = allLocationDistances.FirstOrDefault(ld => ld.From == location && ld.To == allEvents.FirstOrDefault(e => e.Id == eventId).Location)?.DurationMinutes;
                if (duration > 30) // Maksimum 30 dakika
                    return true;
            }
            return false;
        }
    }

}
