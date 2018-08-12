using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptKey = Console.ReadLine();
            var regex = @".*?"
                + Regex.Escape(cryptKey) + @"(?<firstTeamName>[a-zA-Z]*)(.*?)"
                + Regex.Escape(cryptKey) + @"(.*)"
                + Regex.Escape(cryptKey) + @"(?<secondTeamName>[a-zA-Z]*)(.*?)"
                + Regex.Escape(cryptKey) + @"(.*?)(?<firstTeamGoals>\d+):(?<secondTeamGoals>\d+)";
            var teams = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                else
                {
                    Match match = Regex.Match(input, regex);

                        string first_team = match.Groups["firstTeamName"].Value;
                        string second_team = match.Groups["secondTeamName"].Value;
                        string first_goals = match.Groups["firstTeamGoals"].Value;
                        string second_goals = match.Groups["secondTeamGoals"].Value;
                        int goals_of_first = int.Parse(first_goals);
                        int goals_of_second = int.Parse(second_goals);
                        first_team = new string( first_team.ToUpper().Reverse().ToArray());
                        second_team = new string(second_team.ToUpper().Reverse().ToArray());
                        if (teams.ContainsKey(first_team))
                        {
                            teams[first_team] += goals_of_first;
                        }
                        else
                        {
                            teams[first_team] = goals_of_first;
                        }
                        if (teams.ContainsKey(second_team))
                        {
                            teams[second_team] += goals_of_second;
                        }
                        else
                        {
                            teams[second_team] = goals_of_second;
                        }
                }
            }
            int num = 1;
            teams = teams.OrderByDescending(p => p.Value).ThenBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            foreach (string team in teams.Keys)
            {
                Console.WriteLine($"{num}. {team} {teams[team]}");
                num++;
            }
        }
    }
}