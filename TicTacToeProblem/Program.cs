using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Game obj = new Game();
            char[] createBoard=obj.Board();
            char player = obj.Player();
        }
    }
}
