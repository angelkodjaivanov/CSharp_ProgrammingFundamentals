using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
                sum += numbers[i];
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + (sum / count));

        }
    }
}
