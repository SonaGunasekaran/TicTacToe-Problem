using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProblem
{
    class Game
    {

        public char[] Board()
        {
            char[] createBoard = new char[10];
            for (int i=1;i<createBoard.Length;i++)
            {
                createBoard[i] = ' ';
            }

            return createBoard;
            
        }

        public string Player()
        {
           Console.WriteLine("Choose X or O ");
            string playerChoice = Console.ReadLine().ToUpper();
            if (playerChoice == "X" || playerChoice=="O")
            {
                playerChoice = "X";
            }
            else
            {
                playerChoice = "O";
            }
            return  playerChoice;
        }

        public void ShowBoard(char[]createBoard)

        {

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[1], createBoard[2], createBoard[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[4], createBoard[5], createBoard[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[7], createBoard[8], createBoard[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}
