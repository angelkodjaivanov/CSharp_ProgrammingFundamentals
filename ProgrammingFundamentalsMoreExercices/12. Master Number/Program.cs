using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            FindMasterNumbers(num);
        }

        static void FindMasterNumbers(int num)
        {
            
            for (int number = 10; number <= num; number++)
            {
                bool IsSymmetric = false, IsDevisibleBy7 = false, hasEvenDigit = false;
                int saveNum = number, sum = 0;

                if (RotateNumber(number))
                {
                    IsSymmetric = true;
                }
                while ( number > 0) {
                    int digg = number % 10;
                    sum = sum + digg;
                    number = number / 10;
                }
                if ( sum % 7 == 0)
                {
                    IsDevisibleBy7 = true;
                }
                number = saveNum;
                while ( number > 0 )
                {
                    int digg = number % 10;
                    if ( digg % 2 == 0)
                    {
                        hasEvenDigit = true;
                    }
                    number = number / 10;
                }

                number = saveNum;

                if (IsSymmetric && IsDevisibleBy7 && hasEvenDigit)
                {
                    Console.WriteLine(number);
                }

            }
        }

        static bool RotateNumber(int number)
        {
            int n = number;
            int rev = 0;
            while (number > 0)
            {
                int dig = number % 10;
                rev = rev * 10 + dig;
                number = number / 10;
            }
            bool output = false;
            if (n == rev)
            {
                output = true;
            }
            return output;
        }
    }
}
