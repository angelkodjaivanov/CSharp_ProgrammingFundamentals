using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<start>[^\$#\@\^]*)(?<first>[\$\#\@\^]+)([^\$#\@\^]*)(?<second>[\$#\@\^]+)(?<end>[^\$#\@\^]*)$";
            List<string> tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string ticket in tickets)
            {
                Match match = Regex.Match(ticket, pattern);
                if (ticket.Length == 20)
                {
                    if (match.Groups["first"].Value.Length >= 6 && match.Groups["second"].Value.Length >= 6
                            && match.Groups["first"].Value[0] == match.Groups["second"].Value[0])
                    {
                        Console.WriteLine("ticket \"" + ticket + "\" - " + Math.Min(match.Groups["first"].Value.Length, match.Groups["second"].Value.Length) + match.Groups["first"].Value[0]);
                    }
                    else if (match.Groups["first"].Value.Length + match.Groups["second"].Value.Length == 20)
                    {
                        Console.WriteLine("ticket \"" + ticket + "\" - " + 10 + match.Groups["first"].Value[0] + " Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine("ticket \"" + ticket + "\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
               
            }

        }
    }
}
