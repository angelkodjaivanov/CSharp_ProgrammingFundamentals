using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] firstInputArr = firstInput.Split(' ');
            string[] secondInputArr = secondInput.Split(' ');

            int biggestArr = Math.Max(firstInputArr.Length, secondInputArr.Length);

            int indexFirtsArr = 0;
            int indexSecondArr = 0;
            int[] result = new int[biggestArr];

            for (int i = 0; i < biggestArr; i++)
            {

                result[i] = int.Parse(firstInputArr[indexFirtsArr]) + int.Parse(secondInputArr[indexSecondArr]);


                indexFirtsArr++;
                indexSecondArr++;

                if (indexFirtsArr == firstInputArr.Length)
                {
                    indexFirtsArr = 0;
                }
                if (indexSecondArr == secondInputArr.Length)
                {
                    indexSecondArr = 0;
                }
            }

            for (int i = 0; i < result.Length ; i++)
            {
                Console.Write(result[i] + " ");
            }

        }
    }
}
