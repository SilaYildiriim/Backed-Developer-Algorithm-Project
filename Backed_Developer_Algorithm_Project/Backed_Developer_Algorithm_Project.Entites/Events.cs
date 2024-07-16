using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.BaseEntities;

namespace Backed_Developer_Algorithm_Project.Entites
{
    public class Event : BaseEntity
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Priority { get; set; }

        public string Location { get; private set; } // LocationId sadece Event sınıfı içinde değiştirilebilir.

        public Event(int id, TimeSpan startTime, TimeSpan endTime, string location, int priority) : base(id)
        {
            StartTime = startTime;
            EndTime = endTime;
            Priority = priority;
            Location = location;
        }
    }

}
