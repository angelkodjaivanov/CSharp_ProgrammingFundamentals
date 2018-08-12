using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            foreach(string part in input)
            {
                List<string> numbers = part.Split(' ').ToList();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    result.Add(numbers[i]);
                }
            }
            //result.Remove(" ");

            for (int i = result.Count - 1 ; i >= 0; i--)
            {
                Console.Write(result[i] +  " ");
            }
        }
    }
}
