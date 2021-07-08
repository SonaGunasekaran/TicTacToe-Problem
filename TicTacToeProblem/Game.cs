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
            for (int i=1;i<=createBoard.Length;i++)
            {
                createBoard[i] = ' ';
            }
            return createBoard;
        }

        public char Player()
        {
            char[] choice = new char[] { 'X', 'O' };
            Console.WriteLine("Choose X or O ");
            char playerChoice = char.Parse(Console.ReadLine());
            if (playerChoice == choice[0])
            {
                playerChoice = choice[0];
            }
            else
            {
                playerChoice = choice[1];
            }
            return  playerChoice;
        }
    }
}
