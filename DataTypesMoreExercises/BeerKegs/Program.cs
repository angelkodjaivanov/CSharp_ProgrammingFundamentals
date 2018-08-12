using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string result = "";    
            for ( int i = 1; i <= n; i++)
            {
                string type = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume >= maxVolume)
                {
                    maxVolume = volume;
                    result = type;
                }

            }

            Console.WriteLine(result);

        }
    }
}
