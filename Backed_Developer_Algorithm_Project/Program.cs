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
            ILocationDistanceRepository locationDistanceRepository = new LocationDistanceRepository();

            IEventService eventService = new EventService(eventRepository, new LocationDistanceService(locationDistanceRepository));

            var scheduledEvents = eventService.ScheduleEvents();
            int totalPriority = eventService.CalculateTotalPriority(scheduledEvents);

            Console.WriteLine("Katılınabilecek Etkinlik Sayısı: " + scheduledEvents.Count);
            Console.WriteLine("Katılınabilecek Etkinliklerin ID'leri: " + string.Join(", ", scheduledEvents.Select(e => e.Id)));
            Console.WriteLine("Toplam Değer: " + totalPriority);

            Console.ReadLine();
        }
    }
}
