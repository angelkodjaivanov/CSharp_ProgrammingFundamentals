using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = double.Parse(Console.ReadLine());
            if (month == "May" || month == "October")
            {
                if (nights > 7)
                {
                    if (month == "October")
                    {
                        Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (0.95 * ((nights - 1) * 50)));
                        Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 65));
                        Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 75));
                    }
                    else
                    {
                        Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (0.95 * (nights * 50)));
                        Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 65));
                        Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 75));
                    }
                }
                else
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (nights * 50));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 65));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 75));
                }
            }
            if (month == "September" || month == "June")
            {
                if (month == "September" && nights > 7 && nights <= 14)
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", ((nights - 1) * 60));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 72));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 82));
                }
                else if (nights > 14 && month == "June")
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (nights * 60));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (0.90 * (nights * 72)));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 82));
                }
                else if (nights < 14 && month == "June")
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (nights * 60));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 72));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 82));
                }
                else if (nights < 7 && month == "September")
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (nights * 60));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 72));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 82));
                }
                else if (month == "September" && nights > 14)
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", ((nights - 1) * 60));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (0.90 * (nights * 72)));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 82));
                }
            }
            if (month == "July" || month == "August" || month == "December")
            {
                if (nights > 14)
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (nights * 68));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 77));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (0.85 * (nights * 89)));
                }
                else
                {
                    Console.WriteLine("Studio: " + "{0:F2}" + " lv.", (nights * 68));
                    Console.WriteLine("Double: " + "{0:F2}" + " lv.", (nights * 77));
                    Console.WriteLine("Suite: " + "{0:F2}" + " lv.", (nights * 89));
                }
            }

        }
    }
}