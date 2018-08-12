using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            //double result = width * heigth;
            //result = result / 1000000;
            //Console.WriteLine("{0}x{1} => {2}MP", width, heigth, Math.Round(width*heigth / 1000000.0, 1));
            double num = 1.8795666;
            Console.WriteLine("{0:F2}", num);
        }
    }
}
