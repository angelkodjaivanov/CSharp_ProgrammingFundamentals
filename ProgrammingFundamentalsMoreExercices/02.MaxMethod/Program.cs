using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(firstNumber, secondNumber, thirdNumber));

        }

        static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            int number = 0;
            if ( firstNumber >= secondNumber )
            {
                number = firstNumber;
            }
            else
            {
                number = secondNumber;
            }

            if (thirdNumber >= number)
            {
                number = thirdNumber;
            }
          
            return number;
        }
    }
}
