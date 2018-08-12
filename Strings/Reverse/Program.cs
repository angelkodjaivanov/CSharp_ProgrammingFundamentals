using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = new String(Console.ReadLine().Reverse().ToArray());
            Console.WriteLine(text);
        }
    }
}
