using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int saveHealth = health;
            bool weWillLive = true;

            List<string> viruses = new List<string>();
            string virus = Console.ReadLine();
            while (virus != "end")
            {
                bool weHaveTheSameVirus = false;
                

                foreach (string vir in viruses)
                {
                    if (vir == virus)
                    {
                        weHaveTheSameVirus = true;
                    }
                }

                viruses.Add(virus);
                int secondsSum = 0;

                for (int i = 0; i < virus.Length; i++)
                {
                    secondsSum += virus[i];
                }

                int save = secondsSum;
                secondsSum = secondsSum / 3 * virus.Length;

                if (weHaveTheSameVirus)
                {
                    secondsSum = secondsSum / 3;
                }

                Console.WriteLine("Virus {0}: {1} => {2} seconds", virus, save / 3, secondsSum);
                health = health - secondsSum;

                if (health <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    weWillLive = false;
                    break;
                }
                else
                {
                    Console.WriteLine("{0} defeated in {1}m {2}s.", virus, secondsSum / 60, secondsSum - secondsSum / 60 * 60);
                    Console.WriteLine("Remaining health: {0}", health);
                }

                if (health + health / 5 < saveHealth)
                {
                    health += health / 5;
                }
                else
                {
                    health = saveHealth;
                }

                virus = Console.ReadLine();
            }

            if (weWillLive)
            {
                Console.WriteLine("Final Health: {0}", health);
            }

        }
    }
}
