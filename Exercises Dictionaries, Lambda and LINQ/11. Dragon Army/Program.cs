using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()), br = 0;
            Dictionary<string, double> averageDamage = new Dictionary<string, double>();
            Dictionary<string, double> averageHealth = new Dictionary<string, double>();
            Dictionary<string, double> averageArmor = new Dictionary<string, double>();
            Dictionary<string, Dictionary<string, Dictionary<string, double>>> dragons = new Dictionary<string, Dictionary<string, Dictionary<string, double>>>();

            for (int i = 0; i < count; i++)
            {
                List<string> dragonProperties = Console.ReadLine().Split(' ').ToList();
                string damage = "Damage", health = "Health", armor = "Armor";

                if (averageDamage.ContainsKey(dragonProperties[0]))
                {
                    averageDamage[dragonProperties[0]] += double.Parse(dragonProperties[2]);
                    averageDamage[dragonProperties[0]] += double.Parse(dragonProperties[3]);
                    averageDamage[dragonProperties[0]] += double.Parse(dragonProperties[4]);
                    br++;
                }
                else
                {
                    averageDamage[dragonProperties[0]] = double.Parse(dragonProperties[2]);
                    averageDamage[dragonProperties[0]] = double.Parse(dragonProperties[3]);
                    averageDamage[dragonProperties[0]] = double.Parse(dragonProperties[4]);
                    br = 1;
                }

                if ( i == count - 1)
                {
                    averageDamage[dragonProperties[0]] /= br;
                    averageDamage[dragonProperties[0]] /= br;
                    averageDamage[dragonProperties[0]] /= br;
                }

                try
                {
                    dragons[dragonProperties[0]][dragonProperties[1]][damage] = double.Parse(dragonProperties[2]);
                    dragons[dragonProperties[0]][dragonProperties[1]][health] = double.Parse(dragonProperties[3]);
                    dragons[dragonProperties[0]][dragonProperties[1]][armor] = double.Parse(dragonProperties[4]);
                }
                catch (IndexOutOfRangeException)
                {

                }

            }

            foreach (var type in dragons.Keys)
            {
                Console.WriteLine($"{type}::({averageDamage[type]}/{averageHealth[type]}/{averageArmor[type]})");
                foreach (var dragon in dragons[type].Keys)
                {
                    Console.Write($"-{dragon} -> ");

                    int index = 0;
                    foreach (var stat in dragons[type][dragon].Keys)
                    {
                        if (index == 0)
                        {
                            Console.Write($"damage: {stat}, ");
                        }
                        else if (index == 1)
                        {
                            Console.Write($"health: {stat}, ");
                        }
                        else if (index == 2)
                        {
                            Console.Write($"armor: {stat}");
                        }
                        index++;
                    }
                }        
            }

        }
    }
}
