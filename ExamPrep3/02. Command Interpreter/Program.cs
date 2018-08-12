using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');

            while (true)
            {
                string option = Console.ReadLine();
                if (option == "end")
                {
                    break;
                }
                string[] optionProp = option.Split(' ');

                long start = 0, count = 0;
                switch (optionProp[0])
                {
                    case "reverse":
                        start = long.Parse(optionProp[2]);
                        count = long.Parse(optionProp[4]);
                        if ((start >= 0 && start < elements.Length) && (count + start <= elements.Length) && count >= 0)
                        {
                            for (int i = 0; i < count / 2; i++)
                            {
                                string save = elements[i + start];
                                elements[i + start] = elements[count - i + start - 1];
                                elements[count - i + start - 1] = save;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                    case "sort":
                        start = long.Parse(optionProp[2]);
                        count = long.Parse(optionProp[4]);
                        if ((start >= 0 && start < elements.Length) && (count + start <= elements.Length) && count >= 0)
                        {
                            List<string> sortElements = new List<string>();
                            for (long i = start; i < count + start; i++)
                            {
                                sortElements.Add(elements[i]);
                            }
                            sortElements.Sort();
                            for (long i = start; i < count + start; i++)
                            {
                                elements[i] = sortElements[(int)(i - start)];
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                    case "rollLeft":
                        count = long.Parse(optionProp[1]);
                        count = count % elements.Length;
                        if (count >= 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                string save = elements[0];
                                for (int j = 0; j < elements.Length - 1; j++)
                                {
                                    elements[j] = elements[j + 1];
                                }
                                elements[elements.Length - 1] = save;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                    case "rollRight":
                        count = long.Parse(optionProp[1]);
                        count = count % elements.Length;
                        if (count >= 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                string save = elements[elements.Length - 1];
                                for (int j = elements.Length - 1; j > 0; j--)
                                {
                                    elements[j] = elements[j - 1];
                                }
                                elements[0] = save;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                }

            }

                Console.WriteLine("[" + String.Join(", ", elements)+ "]");

        }
    }
}
