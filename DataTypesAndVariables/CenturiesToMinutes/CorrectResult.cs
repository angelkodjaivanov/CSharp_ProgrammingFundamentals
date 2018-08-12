using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class CorrectResult
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
