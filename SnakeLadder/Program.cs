using System;

namespace SnakeLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Game game = new Game();
            game.DieRoll();
        }
    }
}
