using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            int result = 0;
            bool before = true;

            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    before = false;
                    continue;
                }
                if (before)
                {
                    result += email[i];
                }
                else
                {
                    result -= email[i]; 
                }
            }

            if (result >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
    }
}
