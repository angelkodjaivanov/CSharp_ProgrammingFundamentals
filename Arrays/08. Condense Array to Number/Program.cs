using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            double[] arr = new double[items.Length];
            double endSum = 0;

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = double.Parse(items[i]);
            }

            int length = arr.Length - 1;
            if (arr.Length > 1) {
                for (int i = 1; i <= arr.Length - 1; i++) {
                    for (int index = 0; index < length; index++)
                    {
                        if (i == arr.Length - 1)
                        {
                            endSum = arr[index] + arr[index + 1];
                        }
                        arr[index] = arr[index] + arr[index + 1];
                    }
                    length--;
                }
            }
            else
            {
                endSum = arr[0];
            }

            Console.WriteLine(endSum);
        }
    }
}
