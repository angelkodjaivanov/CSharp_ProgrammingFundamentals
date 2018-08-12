using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool weHaveOpeningOne = false, weDecided = false;

            for (int i = 1; i <= n ; i++)
            {
                string input = Console.ReadLine();
                if (weDecided == false) {
                    if (input == "(")
                    {
                        if (weHaveOpeningOne == true)
                        {
                            weDecided = true;
                        }
                        else {
                            weHaveOpeningOne = true;
                        }
                    }
                    else if (input == ")")
                    {
                        if (weHaveOpeningOne == true)
                        {
                            weHaveOpeningOne = false;
                        }
                        else{
                            weDecided = true;
                        }
                        
                    }
                   
                }
               
            }

            if ( weDecided == false && weHaveOpeningOne == false)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
