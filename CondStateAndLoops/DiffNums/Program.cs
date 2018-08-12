using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (second - first >=4)
            {
                int n1 = first, n2 = n1 + 1, n3 = n2 + 1, n4 = n3 + 1, n5 = n4+1 ;

                while (true)
                {
                    Console.WriteLine(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5);
                    if (n5 < second)
                    {
                        n5++;
                    }
                    else if (n4 < n5 - 1)
                    {
                        n4++;
                        n5 = n4 + 1;
                    }
                    else if (n3 < n4 - 1)
                    {
                        n3++;
                        n4 = n3 + 1;
                        n5 = n4 + 1;
                    }
                    else if (n2 < n3 -1)
                    {
                        n2++;
                        n3 = n2 + 1;
                        n4 = n3 + 1;
                        n5 = n4 + 1;
                    }
                    else if (n1 < n2 -1)
                    {
                        n1++;
                        n2 = n1 + 1;
                        n3 = n2 + 1;
                        n4 = n3 + 1;
                        n5 = n4 + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
