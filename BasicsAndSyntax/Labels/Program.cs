using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", ml, product);
            Console.WriteLine("{0}kcal, {1}g sugars", ml * energy / 100.00, ml * sugar / 100.00);

        }
    }
}
