using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine(), secondNumber = Console.ReadLine(), result = "";


            if (firstNumber != "0" && secondNumber != "0")
            {
                for (int i = 0; i < firstNumber.Length; i++)
                {
                    result = result + "0";
                    for (int j = 0; j < firstNumber[i] - 48; j++)
                    {
                        if (result != "")
                        {
                            result = Sum(result, secondNumber);
                        }
                        else
                        {
                            result = Sum("0", secondNumber);
                        }
                    }

                }
            }
            else
            {
                result = "0";
            }

            Console.WriteLine(result);

        }

        static string Sum(string firstNumber, string secondNumber)
        {
            int naum = 0;
            string resultNumber = "";

            while (true)
            {
                if (((int)firstNumber[firstNumber.Length - 1] - 48) + ((int)secondNumber[secondNumber.Length - 1] - 48) + naum >= 10)
                {
                    resultNumber += ((((int)firstNumber[firstNumber.Length - 1] - 48) + ((int)secondNumber[secondNumber.Length - 1] - 48)) + naum) % 10;
                    naum = (((int)firstNumber[firstNumber.Length - 1] - 48) + ((int)secondNumber[secondNumber.Length - 1] - 48) + naum) / 10;
                }
                else
                {
                    resultNumber += ((int)firstNumber[firstNumber.Length - 1] - 48) + ((int)secondNumber[secondNumber.Length - 1] - 48) + naum;
                    naum = (((int)firstNumber[firstNumber.Length - 1] - 48) + ((int)secondNumber[secondNumber.Length - 1] - 48) + naum) / 10;
                }

                firstNumber = firstNumber.Remove(firstNumber.Length - 1, 1);
                secondNumber = secondNumber.Remove(secondNumber.Length - 1, 1);

                if (firstNumber.Length == 0 || secondNumber.Length == 0)
                {
                    if (firstNumber.Length == 0 && secondNumber.Length == 0 && naum > 0)
                    {
                        resultNumber += naum;
                    }
                    break;
                }
            }

            if (firstNumber.Length > secondNumber.Length)
            {
                for (int i = 0; i < firstNumber.Length; i++)
                {
                    if (((int)(firstNumber[firstNumber.Length - i - 1]) + 48 + naum) >= 10)
                    {
                        resultNumber += ((int)(firstNumber[firstNumber.Length - i - 1]) - 48 + naum) % 10;
                        naum = ((int)(firstNumber[firstNumber.Length - i - 1]) - 48 + naum) / 10;
                    }
                    else
                    {
                        resultNumber += (int)(firstNumber[firstNumber.Length - i - 1]) - 48 + naum;
                        naum = ((int)(firstNumber[firstNumber.Length - i - 1]) - 48 + naum) / 10;
                    }
                }
                if (naum > 0)
                {
                    resultNumber += naum;
                }
            }
            else if (firstNumber.Length < secondNumber.Length)
            {
                for (int i = 0; i < secondNumber.Length; i++)
                {
                    if (((int)(secondNumber[secondNumber.Length - i - 1]) + 48 + naum) >= 10)
                    {
                        resultNumber += ((int)(secondNumber[secondNumber.Length - i - 1]) - 48 + naum) % 10;
                        naum = ((int)(secondNumber[secondNumber.Length - i - 1]) - 48 + naum) / 10;
                    }
                    else
                    {
                        resultNumber += (int)(secondNumber[secondNumber.Length - i - 1]) - 48 + naum;
                        naum = ((int)(secondNumber[secondNumber.Length - i - 1]) - 48 + naum) / 10;
                    }
                }
                if (naum > 0)
                {
                    resultNumber += naum;
                }
            }
            resultNumber = new String(resultNumber.Reverse().ToArray()).TrimStart(new Char[] { '0' });

            return resultNumber;
        }
    }
}
