using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Elevator
    {
        public static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int maxSpaceForPeopleInTheElevator = int.Parse(Console.ReadLine());
            int turns = (int)(Math.Ceiling((double)people / maxSpaceForPeopleInTheElevator));
            Console.WriteLine(turns);
        }
    }
}
 