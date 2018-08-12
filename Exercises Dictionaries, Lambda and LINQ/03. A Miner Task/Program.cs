using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            Dictionary<string, long> resources = new Dictionary<string, long>();

            while(product != "stop")
            {
                long value = long.Parse(Console.ReadLine());
                bool isTrue = false;

                foreach (var res in resources.Keys)
                {
                    if (res == product)
                    {
                        
                        isTrue = true;
                    }
                }

                if (isTrue == false)
                {

                    resources[product] = value;
                }
                else
                {
                    resources[product] += value;
                }

                product = Console.ReadLine();
            }

            foreach (var name in resources.Keys)
            {
                Console.WriteLine($"{name} -> {resources[name]}");
            }

        }
    }
}
