using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.IRepositories;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites;
using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService;
using Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly ILocationDistanceService _locationDistanceService;

        public EventService(IEventRepository eventRepository, ILocationDistanceService locationDistanceService)
        {
            _eventRepository = eventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
            _locationDistanceService = locationDistanceService ?? throw new ArgumentNullException(nameof(locationDistanceService));
        }

        public List<Event> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public List<Event> GetFilteredEvents()
        {
            var now = DateTime.Now.TimeOfDay;
            return _eventRepository.GetAllEvents()
                .Where(e => e.StartTime > now)
                .OrderByDescending(e => e.Priority)
                .ThenBy(e => e.StartTime)
                .ToList();
        }

        public List<Event> ScheduleEvents()
        {
            var events = GetFilteredEvents();
            var locationDistances = _locationDistanceService.GetAllLocationDistances();

            List<Event> scheduledEvents = new List<Event>();
            TimeSpan currentEndTime = TimeSpan.Zero;

            foreach (var currentEvent in events)
            {
                if (scheduledEvents.Count == 0 || CanScheduleEvent(currentEvent, scheduledEvents.Last(), locationDistances, currentEndTime))
                {
                    scheduledEvents.Add(currentEvent);
                    currentEndTime = currentEvent.EndTime;
                }
            }

            return scheduledEvents;
        }

        private bool CanScheduleEvent(Event currentEvent, Event nextEvent, List<LocationDistance> locationDistances, TimeSpan currentEndTime)
        {
            var distance = locationDistances.FirstOrDefault(d =>
                (d.From == currentEvent.Location && d.To == nextEvent.Location));

            if (distance == null)
                return true;

            TimeSpan updateEndTime = currentEndTime + distance.DurationMinutes;
            return updateEndTime <= nextEvent.StartTime;
        }

        public int CalculateTotalPriority(List<Event> events)
        {
            return events.Sum(e => e.Priority);
        }
    }
}
