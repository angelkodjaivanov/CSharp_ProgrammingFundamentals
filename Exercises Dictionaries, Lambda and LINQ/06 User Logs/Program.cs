using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> IP = new Dictionary<string, List<string>>();

            int br = 0;
            while (input != "end")
            {
                List<string> log = input.Split(' ', '=').ToList();
                string ip = log[1], message = log[3], name = log[5];

                IP[name].Add(ip);

                input = Console.ReadLine();
            }

            foreach (string name in IP.Keys)
            {
                for (int i = 0; i < IP[name].Count; i++)
                {
                    Console.WriteLine(IP[name][i]);
                }
            }

        }
    }
}
