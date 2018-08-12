using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());
            long result = 0;

            if ( price1 >= -128 && price1 <= 127)
            {
                result = result + price1 * 4 + price2 * 10;
            }
            else
            {
                result = result + price1 * 10 + price2 * 4;
            }

            Console.WriteLine(result);

        }
    }
}
