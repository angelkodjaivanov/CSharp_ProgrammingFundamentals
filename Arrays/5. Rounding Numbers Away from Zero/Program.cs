using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            double[] arr = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = double.Parse(items[i]);
            }

            for (int i = 0; i < arr.Length; i++ )
            {
                double saveOldValue = arr[i];
                arr[i] = Math.Round(arr[i],MidpointRounding.AwayFromZero); ;
                Console.WriteLine("{0} => {1}", saveOldValue, arr[i]);
            }

        }
    }
}
