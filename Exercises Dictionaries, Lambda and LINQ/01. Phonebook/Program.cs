using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contact = new Dictionary<string, string>();

            while (input != "END")
            {
                List<string> list = input.Split(' ').ToList();
                bool foundName = false;

                if (list[0] == "A")
                {
                    contact[list[1]] = list[2];
                }
                else if (list[0] == "S")
                {
                    foreach (string name in contact.Keys)
                    {
                        if (name == list[1])
                        {
                            Console.WriteLine($"{name} -> {contact[name]}");
                            foundName = true;
                        }
                    }
                    if (foundName == false)
                    {
                        Console.WriteLine("Contact {0} does not exist.", list[1]);
                    }
                }
                input = Console.ReadLine();

            }

        }
    }
}
