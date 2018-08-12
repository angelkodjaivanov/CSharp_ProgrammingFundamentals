using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex emailCheck = new Regex(@"\w+@\w+.\w+");
            string email = Console.ReadLine();

            if (emailCheck.IsMatch(email))
            {
                Console.WriteLine("Stava be");
            }
            else
            {
                Console.WriteLine("Ne moe tuj da e email");
            }

        }
    }
}
