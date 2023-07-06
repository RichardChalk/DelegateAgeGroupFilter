using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAgeGroupFilter
{
    public static class Display
    {
        public static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write("=");
            }
            
            Console.WriteLine();

            foreach (var p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name} is {p.Age} years old");
                }
            }
        }

        // Filter methods
        public static bool IsChild(Person p)
        {
            return p.Age < 18; 
        }

        public static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        public static bool IsPensioner(Person p)
        {
            return p.Age >= 65;
        }
    }
}
