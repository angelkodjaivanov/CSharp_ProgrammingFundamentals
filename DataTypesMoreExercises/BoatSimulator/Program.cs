using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());
            char winner = ' ';
            int n = int.Parse(Console.ReadLine());
            int character1Score = 0, character2Score = 0;
            bool isAlreadyWinner = false;
            


            for (int i = 1; i <= n; i++)
            {
                string textAddingMoves = Console.ReadLine();

                if (isAlreadyWinner == false) {
                    if (textAddingMoves != "UPGRADE")
                    {
                        if (i % 2 == 1)
                        {
                            character1Score = character1Score + textAddingMoves.Length;
                            if (character1Score >= 50)
                            {
                                winner = character1;
                                isAlreadyWinner = true;
                            }
                        }
                        else
                        {
                            character2Score = character2Score + textAddingMoves.Length;
                            if (character2Score >= 50)
                            {
                                winner = character2;
                                isAlreadyWinner = true;
                            }
                        }
                    }
                    else
                    {
                        character1 = (char)(character1 + 3);
                        character2 = (char)(character2 + 3);
                    }
                }
            }

            if ( isAlreadyWinner == true )
            {
                Console.WriteLine(winner);
            }
            else
            {
                if (character1Score > character2Score)
                {
                    Console.WriteLine(character1);
                }
                else
                {
                    Console.WriteLine(character2);
                }
            }

        }
    }
}
