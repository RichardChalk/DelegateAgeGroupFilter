
namespace DelegateAgeGroupFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person() { Name = "Richard", Age= 53 };
            var p2 = new Person() { Name = "Stefan", Age= 54 };
            var p3 = new Person() { Name = "Lucas", Age= 9 };
            var p4 = new Person() { Name = "Alicia", Age= 16 };
            var p5 = new Person() { Name = "Gun", Age= 80 };

            var people = new List<Person>() { p1, p2, p3, p4, p5 };
                        
            Display.DisplayPeople("Barn", people, Display.IsChild);
            Display.DisplayPeople("Vuxna", people, Display.IsAdult);
            Display.DisplayPeople("Oldies", people, Display.IsPensioner);
        }
    }
}