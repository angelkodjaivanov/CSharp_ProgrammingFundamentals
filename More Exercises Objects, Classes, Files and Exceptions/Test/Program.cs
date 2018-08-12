using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        class test1
        {
            public test2 MyProperty { get; set; }
            public test2 Your { get; set; }
        }

        class test2
        {
            public int Thetest { get; set; }
            public int YourTest { get; set; }
        }

        static void Main(string[] args)
        {
            test1 forTheTest = new test1();
            forTheTest.Your.Thetest = 23;
            Console.WriteLine(forTheTest.Your.Thetest);
        }
    }
}
