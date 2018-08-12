using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> result = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (email[email.Length - 2] != 'u' && email[email.Length - 1] != 'k' && email[email.Length - 1] != 's')
                {
                    result[name] = email;
                }

                name = Console.ReadLine();

            }


            foreach (var nameGuy in result.Keys)
            {
                Console.WriteLine($"{nameGuy} -> {result[nameGuy]}");
            }

        }
    }
}
