using Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Service.IService
{
    public interface IEventService
    {
        int CalculateTotalPriority(List<Event> scheduledEvents);
        List<Event> GetAllEvents();
        List<Event> GetFilteredEvents();
        List<Event> ScheduleEvents();
    }


}
