using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintTheHeader();
            PrintTheBody();
            PrintTheFooter();
        }
       
        static void PrintTheHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintTheBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintTheFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9" + " SoftUni");
        }

    }
}
