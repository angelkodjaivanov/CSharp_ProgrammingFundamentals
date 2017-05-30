using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characther_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int statOne = int.Parse(Console.ReadLine());
            int maxStatOne = int.Parse(Console.ReadLine());
            int statTwo= int.Parse(Console.ReadLine());
            int maxStatTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', statOne), new string('.', maxStatOne - statOne));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', statTwo), new string('.', maxStatTwo - statTwo));

        }
    }
}
