using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                List<string> operations = input.Split(' ').ToList();

                switch (operations[0])
                {
                    case "exchange":
                        long count = long.Parse(operations[1]);
                        if ((count < numbers.Count) && (count >= 0))
                        {
                            int[] helper = new int[count + 1];
                            for (int i = 0; i <= count; i++)
                            {
                                helper[i] = numbers[0];
                                numbers.Remove(numbers[0]);
                            }
                            for (int i = 0; i < helper.Length; i++)
                            {
                                numbers.Add(helper[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        int max = -1, index = -1;
                        if (operations[1] == "even")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= max && numbers[i] % 2 == 0)
                                {
                                    max = numbers[i];
                                    index = i;
                                }
                            }
                            if (index >= 0)
                            {
                                Console.WriteLine(index);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }

                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= max && numbers[i] % 2 == 1)
                                {
                                    max = numbers[i];
                                    index = i;
                                }
                            }
                            if (index >= 0)
                            {
                                Console.WriteLine(index);
                            }
                            else
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "min":
                        int min = 10001, indexMin = -1;
                        if (operations[1] == "even")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] % 2 == 0 && numbers[i] <= min)
                                {
                                    min = numbers[i];
                                    indexMin = i;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] % 2 == 1 && numbers[i] <= min)
                                {
                                    min = numbers[i];
                                    indexMin = i;
                                }
                            }
                        }
                        if (indexMin >= 0)
                        {
                            Console.WriteLine(indexMin);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "first":
                        long counter = long.Parse(operations[1]), curIndex = 0;                      
                        if (counter <= numbers.Count && counter >= 0)
                        {
                            List<int> firts = new List<int>();
                            if (operations[2] == "even")
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (curIndex  == counter)
                                    {
                                        break;
                                    }
                                    if (numbers[i] % 2 == 0)
                                    {
                                        firts.Add(numbers[i]);
                                        curIndex++;
                                    }
                                }
                            }
                            else
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (curIndex == counter)
                                    {
                                        break;
                                    }
                                    if (numbers[i] % 2 == 1)
                                    {
                                        firts.Add(numbers[i]);
                                        curIndex++;
                                    }
                                }
                            }
                            Console.WriteLine("["+String.Join(", ", firts)+"]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                    case "last":
                        long counterLast = long.Parse(operations[1]), currIndex = 0;
                        if (counterLast <= numbers.Count && counterLast >= 0)
                        {
                            List<int> last = new List<int>();
                            if (operations[2] == "even")
                            {
                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if (currIndex == counterLast)
                                    {
                                        break;
                                    }
                                    if (numbers[i] % 2 == 0)
                                    {
                                        last.Add(numbers[i]);
                                        currIndex++;
                                    }
                                }
                            }
                            else
                            {
                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if (currIndex == counterLast)
                                    {
                                        break;
                                    }
                                    if (numbers[i] % 2 == 1)
                                    {
                                        last.Add(numbers[i]);
                                        currIndex++;
                                    }
                                }
                            }

                            last.Reverse();

                            Console.WriteLine("["+String.Join(", ", last)+"]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }

            }

            Console.WriteLine("[" + String.Join(", ", numbers) +"]");

        }
    }
}
