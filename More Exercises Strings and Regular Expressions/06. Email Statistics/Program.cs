using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex emailChecker = new Regex(@"^([a-zA-Z])+@(\w+)(.bg|.com|.org)$");

            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();
                if (emailChecker.IsMatch(email))
                {
                    
                }
            }

        }
    }
}
