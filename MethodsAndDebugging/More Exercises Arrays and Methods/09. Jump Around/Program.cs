using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputToArray = input.Split(' ');
            int[] numbers = new int[inputToArray.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputToArray[i]);
            }

            int sum = numbers[0], index = 0, saveIndex = 0;
            while (true)
            {

                try
                {
                    saveIndex = index;
                    index += numbers[index];
                    sum += numbers[index];
                }
                catch (IndexOutOfRangeException)
                {
                    try
                    {
                        index -= numbers[saveIndex];
                        index -= numbers[index];
                        sum += numbers[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine(sum);
                        break;
                    }
                }
                
            }

        }
    }
}
