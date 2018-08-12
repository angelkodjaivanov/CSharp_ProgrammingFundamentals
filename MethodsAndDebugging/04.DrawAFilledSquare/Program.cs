using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawHeaderRow(n);
            DrawBody(n);
            DrawHeaderRow(n);
        }

        private static void DrawBody(int n)
        {
            for ( int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("\\");
                    Console.Write("/");
                }
                Console.WriteLine("-");
            }
        }

        private static void DrawHeaderRow(int n)
        {
            Console.WriteLine(new String('-', 2 * n));
        }
    }
}
