using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double strLength = double.Parse(Console.ReadLine());
            string searchingValue = Console.ReadLine();
            FindResult(strLength, searchingValue);
        }

        static void FindResult(double strLength, string searchingValue)
        {
            double result = 0;
            if (searchingValue == "face")
            {
                result = Math.Sqrt(2 * strLength * strLength);
            }
            else if (searchingValue == "space")
            {
                result = Math.Sqrt(3 * strLength * strLength);
            }
            else if (searchingValue == "volume")
            {
                result = strLength * strLength * strLength;
            }
            else if (searchingValue == "area")
            {
                result = 6 * strLength * strLength;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
