using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKil
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kil = miles * 1.60934;
            Console.WriteLine("{0:F2}", kil);
        }
    }
}
