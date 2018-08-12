using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaluriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfKal = 0;
            for ( int i = 0; i < n; i++)
            {
                var pr = Console.ReadLine().ToLower();
                if (pr == "cheese")
                {
                    sumOfKal = sumOfKal + 500;
                }
                else if (pr == "tomato sauce")
                {
                    sumOfKal = sumOfKal + 150;
                }
                else if (pr == "salami")
                {
                    sumOfKal = sumOfKal + 600;
                }
                else if (pr == "pepper")
                {
                    sumOfKal = sumOfKal + 50;
                }
            }

            Console.WriteLine("Total calories: {0}", sumOfKal);

        }
    }
}
