using System;

namespace SnakesAndLadder
{
    internal class Program
    {
        public static int RollDice()
        {
            return new Random().Next(1,7);
        }
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Player is at {0}", position);
            Console.WriteLine("Player gets: " + RollDice());
        }
    }
}
