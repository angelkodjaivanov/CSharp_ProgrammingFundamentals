using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).OrderBy(p => -p).ToList();
            int index = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[index]) != (int)Math.Sqrt(numbers[index]))
                {
                    numbers.Remove(numbers[index]);
                    i--;
                }
                else
                {
                    index++;
                }
            }
               
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
