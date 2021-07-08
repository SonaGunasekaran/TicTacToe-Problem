using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] createBoard;
            Game obj = new Game();
            createBoard=obj.Board();
            string player = obj.Player();
           obj.ShowBoard(createBoard);
        }
    }
}
