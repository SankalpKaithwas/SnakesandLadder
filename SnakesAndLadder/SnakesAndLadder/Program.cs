using System;

namespace SnakesAndLadder
{
    internal class Program
    {
        public static int RollDice()
        {
            return new Random().Next(1, 7);
        }
        static void Main(string[] args)
        {
            int position = 0;    
            int checkOption = new Random().Next(0, 3);
            int rollDice = RollDice();
            Console.WriteLine("PLayer got {0} on dice",rollDice);

            switch (checkOption)    //Player checks an option
            {
                case 0:
                    position += 0;
                    Console.WriteLine("Player stayed at {0} position", position);
                    break;
                case 1:
                    position += rollDice;
                    Console.WriteLine("Player moved to {0} position", position);
                    break;
                case 2:
                    if (position >= rollDice)
                    {
                        position -= rollDice;
                    }
                    Console.WriteLine("Player moved back to {0} position", position);
                    break;
            }
            
        }
    }
}
