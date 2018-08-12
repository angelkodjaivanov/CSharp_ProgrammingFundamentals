using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> result = new Dictionary<string, int>();

            while(input != "JOKER")
            {
                List<string> heroes = input.Split(' ', ',', ':').Where(p => p != "").Distinct().ToList();
                //int addScore = 0;
                bool thereIsAHero = false;
                bool thereIsAValue = false;

                foreach (var hero in result.Keys)
                {
                    if (hero == heroes[0])
                    {
                        thereIsAHero = true;
                        if (result[hero] > 0)
                        {
                            thereIsAValue = true;
                        }
                    }

                }

                for (int i = 1; i < heroes.Count; i++)
                {
                    if (thereIsAValue == true)
                    {
                        result[heroes[0]] += ChangeToValue(heroes[i]);
                    }
                    else
                    {
                        result[heroes[0]] = ChangeToValue(heroes[i]);
                        thereIsAValue = true;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var name in result.Keys)
            {
                Console.WriteLine($"{name} -> {result[name]}");
            }

        }

        static int ChangeToValue(string card)
        {
            int result = 0;
            if (card[0] != '1')
            {
                if (card[1] == 'C')
                {
                    if (card[0] != 'A' && card[0] != 'K' && card[0] != 'Q' && card[0] != 'J')
                    {
                        result += card[0] - 48;
                    }
                    else if (card[0] == 'A')
                    {
                        result += 14;
                    }
                    else if (card[0] == 'K')
                    {
                        result += 13;
                    }
                    else if (card[0] == 'Q')
                    {
                        result += 12;
                    }
                    else if (card[0] == 'J')
                    {
                        result += 11;
                    }
                }
                else if (card[1] == 'D')
                {
                    if (card[0] != 'A' && card[0] != 'K' && card[0] != 'Q' && card[0] != 'J')
                    {
                        result += (card[0] - 48) * 2;
                    }
                    else if (card[0] == 'A')
                    {
                        result += 14 * 2;
                    }
                    else if (card[0] == 'K')
                    {
                        result += 13 * 2;
                    }
                    else if (card[0] == 'Q')
                    {
                        result += 12 * 2;
                    }
                    else if (card[0] == 'J')
                    {
                        result += 11 * 2;
                    }
                }
                else if (card[1] == 'H')
                {
                    if (card[0] != 'A' && card[0] != 'K' && card[0] != 'Q' && card[0] != 'J')
                    {
                        result += (card[0] - 48) * 3;
                    }
                    else if (card[0] == 'A')
                    {
                        result += 14 * 3;
                    }
                    else if (card[0] == 'K')
                    {
                        result += 13 * 3;
                    }
                    else if (card[0] == 'Q')
                    {
                        result += 12 * 3;
                    }
                    else if (card[0] == 'J')
                    {
                        result += 11 * 3;
                    }
                }
                else if (card[1] == 'S')
                {
                    if (card[0] != 'A' && card[0] != 'K' && card[0] != 'Q' && card[0] != 'J')
                    {
                        result += (card[0] - 48) * 4;
                    }
                    else if (card[0] == 'A')
                    {
                        result += 14 * 4;
                    }
                    else if (card[0] == 'K')
                    {
                        result += 13 * 4;
                    }
                    else if (card[0] == 'Q')
                    {
                        result += 12 * 4;
                    }
                    else if (card[0] == 'J')
                    {
                        result += 11 * 4;
                    }
                }
            }
            else
            {
                switch(card[2]){
                    case 'C': result += 10 * 1; break;
                    case 'D': result += 10 * 2; break;
                    case 'H': result += 10 * 3; break;
                    case 'S': result += 10 * 4; break;
                }
            }

            return result;
        }
    }
}
