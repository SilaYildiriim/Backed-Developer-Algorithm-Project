using Backed_Developer_Algorithm_Project.Backed_Developer_Algorithm_Project.BaseEntities;

namespace Backed_Developer_Algorithm_Project.Entites
{
    public class Location
    {
        public string Name { get; private set; } // Name sadece Location sınıfı içinde değiştirilebilir.

        public Location(string name)
        {
            Name = name;
        }
    }

}