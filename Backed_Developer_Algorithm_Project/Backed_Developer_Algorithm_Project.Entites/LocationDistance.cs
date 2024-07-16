namespace Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.Entites
{
    public class LocationDistance
    {
        public string From { get; set; }
        public string To { get; set; }
        public TimeSpan DurationMinutes { get; set; }

        public LocationDistance(string from, string to, TimeSpan durationMinutes)
        {
            From = from;
            To = to;
            DurationMinutes = durationMinutes;
        }
    }

}
