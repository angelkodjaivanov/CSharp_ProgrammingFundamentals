using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {

            try{
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
