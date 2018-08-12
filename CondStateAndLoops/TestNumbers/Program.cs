using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int comb = 0;
            int sum = 0;
            bool end = false;

            for (int i = n; i>=1; i--)
            {
                for (int j = 1; j <= m; j++ )
                {
                    comb++;
                    sum = sum + 3 * (j * i);
                    if ( sum >= maxSum)
                    {
                        end = true;
                        break;
                    }
                }
                if (end == true)
                {
                    break;
                }
            }

            Console.WriteLine("{0} combinations", comb);
            if (end == true)
            {
                Console.WriteLine("Sum: {0} >= {1}", sum, maxSum);
            }
            else
            {
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
