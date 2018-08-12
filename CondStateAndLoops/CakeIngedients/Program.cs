using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngedients
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            while (true)
            {
                var product = Console.ReadLine();
                if (product == "Bake!")
                {
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.", product);
                br++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", br);
        }
    }
}
