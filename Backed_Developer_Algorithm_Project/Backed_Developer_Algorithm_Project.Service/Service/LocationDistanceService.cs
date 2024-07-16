using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.IRepositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.Service
{
    public class LocationDistanceService : ILocationDistanceService
    {
        private readonly ILocationDistanceRepository _locationDistanceRepository;

        public LocationDistanceService(ILocationDistanceRepository locationDistanceRepository)
        {
            _locationDistanceRepository = locationDistanceRepository ?? throw new ArgumentNullException(nameof(locationDistanceRepository));
        }

        public List<LocationDistance> GetAllLocationDistances()
        {
            return _locationDistanceRepository.GetAllLocationDistances();
        }
    }


}
