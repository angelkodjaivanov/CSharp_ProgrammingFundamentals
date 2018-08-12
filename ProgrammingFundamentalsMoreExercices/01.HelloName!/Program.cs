using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }

        static void HelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
