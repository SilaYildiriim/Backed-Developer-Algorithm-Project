using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.IRepositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.Repositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.Service;

namespace Backed_Developer_Algorithm_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEventRepository eventRepository = new EventRepository();
            ILocationDistanceRepository distanceRepository = new LocationDistanceRepository();
            IEventService eventService = new EventService(eventRepository);
            ILocationDistanceService locationDistanceService = new LocationDistanceService(distanceRepository);

            eventService.ScheduleEvents();


            Console.ReadLine();
        }
    }
}
