using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.IRepositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService;
using Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void ScheduleEvents()
        {
            var events = _eventRepository.GetAllEvents();

            // Zaman sırasına göre etkinlikleri sırala
            events.Sort((e1, e2) => e1.Priority.CompareTo(e2.Priority));

            List<int> scheduledEventIds = new List<int>();
            int totalValue = 0;

            foreach (var ev in events)
            {
                if (!IsEventOverlap(ev, events))
                {
                    scheduledEventIds.Add(ev.Id);
                    totalValue += ev.Priority;

                    // İstenilen maksimum etkinlik sayısına ulaşıldıysa döngüyü sonlandır
                    if (scheduledEventIds.Count == 3)
                        break;
                }
            }

            // Sonuçları yazdır
            Console.WriteLine("Katılınabilecek Maksimum Etkinlik Sayısı: " + scheduledEventIds.Count);
            Console.WriteLine("Katılınabilecek Etkinliklerin ID'leri: " + string.Join(", ", scheduledEventIds));
            Console.WriteLine("Toplam Değer: " + totalValue);
        }

        private bool IsEventOverlap(Event newEvent, List<Event> allEvents)
        {
            foreach (var ev in allEvents)
            {
                if (ev.Id != newEvent.Id && ev.Location == newEvent.Location)
                {
                    if (!((newEvent.EndTime <= ev.StartTime) || (newEvent.StartTime >= ev.EndTime)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
