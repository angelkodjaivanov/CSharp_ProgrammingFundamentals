using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if ( startNum <= endNum) {
                for (int i = startNum; i <= endNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = endNum; i <= startNum; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
