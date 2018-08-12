using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int overTheSymb = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                char symb = char.Parse(Console.ReadLine());
                result = result + (char)(symb + overTheSymb);
            }

            Console.WriteLine(result);

        }
    }
}
