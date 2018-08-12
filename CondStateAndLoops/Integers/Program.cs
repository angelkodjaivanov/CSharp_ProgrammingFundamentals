using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    br++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(br);
            }
        }
    }
}
