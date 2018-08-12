using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptKey = Console.ReadLine();
            List<Team> teams = new List<Team>();
            string pattern = @".*?"
                + Regex.Escape(cryptKey) + @"(?<firstTeamName>[a-zA-Z]*)(.*?)"
                + Regex.Escape(cryptKey) + @"(.*)"
                + Regex.Escape(cryptKey) + @"(?<secondTeamName>[a-zA-Z]*)(.*?)"
                + Regex.Escape(cryptKey) + @"(.*?)(?<firstTeamGoals>\d+):(?<secondTeamGoals>\d+)";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                    int firstTeamPoints = 0, secondTeamPoints = 0;
                    if (long.Parse(match.Groups["firstTeamGoals"].Value) > long.Parse(match.Groups["secondTeamGoals"].Value))
                    {
                        firstTeamPoints = 3;
                        secondTeamPoints = 0;
                    }
                    else if (long.Parse(match.Groups["firstTeamGoals"].Value) < long.Parse(match.Groups["secondTeamGoals"].Value))
                    {
                        firstTeamPoints = 0;
                        secondTeamPoints = 3;
                    }
                    else
                    {
                        firstTeamPoints = 1;
                        secondTeamPoints = 1;
                    }

                    bool haveFirstTeam = false, haveSecondTeam = false;
                    int firstTeamIndex = 0, secondTeamIndex = 0;
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].Name == match.Groups["firstTeamName"].Value.ToLower())
                        {
                            haveFirstTeam = true;
                            firstTeamIndex = i;
                        }
                        if (teams[i].Name == match.Groups["secondTeamName"].Value.ToLower())
                        {
                            haveSecondTeam = true;
                            secondTeamIndex = i;
                        }
                    }

                    if (haveFirstTeam)
                    {
                        teams[firstTeamIndex].Points += firstTeamPoints;
                        teams[firstTeamIndex].Goals += long.Parse(match.Groups["firstTeamGoals"].Value);
                    }
                    if (haveSecondTeam)
                    {
                        teams[secondTeamIndex].Points += secondTeamPoints;
                        teams[secondTeamIndex].Goals += long.Parse(match.Groups["secondTeamGoals"].Value);
                    }

                    if (!haveFirstTeam)
                    {
                        teams.Add(new Team
                        {
                            Name = match.Groups["firstTeamName"].Value.ToLower(),
                            Points = firstTeamPoints,
                            Goals = long.Parse(match.Groups["firstTeamGoals"].Value)
                        });
                    }
                    if (!haveSecondTeam)
                    {
                        teams.Add(new Team
                        {
                            Name = match.Groups["secondTeamName"].Value.ToLower(),
                            Points = secondTeamPoints,
                            Goals = long.Parse(match.Groups["secondTeamGoals"].Value)
                        });
                    }
            }

            for (int i = 0; i < teams.Count; i++)
            {
                teams[i].Name = new string(teams[i].Name.ToUpper().Reverse().ToArray());
            }

            teams = teams.OrderByDescending(p => p.Points).ThenBy(p => p.Name).ToList();

            Console.WriteLine("League standings:");
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + teams[i].Name + " " + teams[i].Points);
            }

            Console.WriteLine("Top 3 scored goals:");

            teams = teams.OrderByDescending(p => p.Goals).ThenBy(p => p.Name).ToList();

            if (teams.Count >= 3)
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("- " + teams[i].Name + " -> " + teams[i].Goals);
                }
            }
            else
            {
                for (int i = 0; i < teams.Count; i++)
                {
                    Console.WriteLine("- " + teams[i].Name + " -> " + teams[i].Goals);
                }
            }

        }

        class Team
        {
            public string Name { get; set; }
            public int Points { get; set; }
            public long Goals { get; set; }
        }
    }
}
