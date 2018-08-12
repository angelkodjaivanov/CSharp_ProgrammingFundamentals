using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] nums = new long[n];
            nums[0] = 1;
            Console.Write(nums[0] + " ");

            for (int i = 0; i < n - 1; i++)
            {
                long number = 0;
                if ( i + 1 <= k )
                {
                    for (int j = i; j >= 0; j-- )
                    {
                        number += nums[j];
                    }
                    Console.Write(number + " ");
                }
                else
                {
                    for (int j = i; j > i - k; j--)
                    {
                        number += nums[j];
                    }
                    Console.Write(number + " ");
                }
                nums[i + 1] = number;
            }

        }
    }
}
