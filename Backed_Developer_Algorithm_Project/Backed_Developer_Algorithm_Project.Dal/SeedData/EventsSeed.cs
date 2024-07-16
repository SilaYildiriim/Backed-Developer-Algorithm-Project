using Backed_Developer_Algorithm_Project.Entites;

namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Dal.SeedData
{
    public class EventsSeed
    {
        public static List<Event> Events = new List<Event>
        {
        new Event(1, TimeSpan.Parse("10:00"), TimeSpan.Parse("12:00"), "A", 50),
        new Event(2, TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00"), "B", 30),
        new Event(3, TimeSpan.Parse("11:30"), TimeSpan.Parse("12:30"), "A", 40),
        new Event(4, TimeSpan.Parse("14:30"), TimeSpan.Parse("16:00"), "C", 70),
        new Event(5, TimeSpan.Parse("14:25"), TimeSpan.Parse("15:30"), "B", 60),
        new Event(6, TimeSpan.Parse("13:00"), TimeSpan.Parse("14:00"), "D", 80)
        };
    }
}
