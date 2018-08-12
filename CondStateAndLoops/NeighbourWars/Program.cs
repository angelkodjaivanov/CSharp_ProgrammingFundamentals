using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());
            int PeshoHealth = 100, GoshoHealth = 100;

            for (int i = 1; true ; i++)
            {
                if ( i % 2 == 1)
                {
                    GoshoHealth = GoshoHealth - PeshoDamage;
                    if (GoshoHealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshoHealth);
                        if (i % 3 == 0)
                        {
                            PeshoHealth = PeshoHealth + 10;
                            GoshoHealth = GoshoHealth + 10;
                        }
                    }
                }
                else
                {
                    PeshoHealth = PeshoHealth - GoshoDamage;
                    if (PeshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshoHealth);
                        if (i % 3 == 0)
                        {
                            GoshoHealth = GoshoHealth + 10;
                            PeshoHealth = PeshoHealth + 10;
                        }
                    }
                }
            }

        }
    }
}
