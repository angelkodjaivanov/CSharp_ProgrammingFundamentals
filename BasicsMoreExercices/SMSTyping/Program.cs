using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 1; i <= n ; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    output = output + " ";
                }
                else if (number < 10 && number > 0)
                {
                    if ( number > 7)
                    {
                        char symb = (char)(96 + 3 * (number - 2) + 2);
                        output = output + symb;
                    }
                    else
                    {
                        char symb = (char)(96 + 3 * (number - 2) + 1);
                        output = output + symb;
                    }
                } 
                else if ( number>= 10 && number < 100)
                {
                    if (number > 77)
                    {
                        char symb = (char)(96 + 3 * (number % 10 - 2) + 3);
                        output = output + symb;
                    }
                    else
                    {
                        char symb = (char)(96 + 3 * (number % 10 - 2) + 2);
                        output = output + symb;
                    }
                }
                else if(number >= 100 && number < 1000)
                {
                    if (number > 777)
                    {
                        char symb = (char)(96 + 3 * (number % 10 - 2) + 4);
                        output = output + symb;
                    }
                    else
                    {
                        char symb = (char)(96 + 3 * (number % 10 - 2) + 3);
                        output = output + symb;
                    }
                }
                else
                {
                    if (number == 7777)
                    {
                        output = output + "s";
                    }
                    else{
                        output = output + "z";
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
