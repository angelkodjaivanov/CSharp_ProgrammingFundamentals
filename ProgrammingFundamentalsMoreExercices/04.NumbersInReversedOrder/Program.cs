using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Rotate(number));
        }

        static string Rotate(string number)
        {
            string output = "";
            char[] num = number.ToCharArray();
            int index = number.Length , i = 1; 

            while (i != number.Length + 1)
            {
                output = output + num[index - i];
                i++;
            } 

            return output;
        }
    }
}
