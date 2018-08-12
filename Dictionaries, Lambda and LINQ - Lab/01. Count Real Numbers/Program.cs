using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
             SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

             foreach (var num in numbers)
                 dict[num] = 0;

             foreach (var num in numbers)
                 dict[num]++;

            foreach (var num in dict.Keys)
            {
                Console.WriteLine($"{num} -> {dict[num]}");
            }
        }
    }
}
