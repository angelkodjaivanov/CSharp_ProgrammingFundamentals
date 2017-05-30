using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            Console.Write("{0:D4} {1:D4} {2:D4} {3:D4}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        }
    }
}
