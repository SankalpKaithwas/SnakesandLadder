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
            while (position != 100 && position <= 100)
            {
                int rollDice = RollDice();
                Console.WriteLine("PLayer got {0} on dice", rollDice);
                int checkOption = new Random().Next(0, 3);
                switch (checkOption)    //Player checks an option
                {   // No play
                    case 0:
                        position += 0;
                        Console.WriteLine("Player stayed at {0} position", position);
                        break;
                    // Ladder
                    case 1:

                        if (position != 100 && position < 100)
                        {
                            int currentPos = position + rollDice;
                            if (currentPos <= 100)
                            {
                                position += rollDice;
                            }
                        }
                        Console.WriteLine("Player moved to {0} position", position);
                        break;
                    // Snake bite
                    case 2:
                        if (position >= rollDice)
                        {
                            position -= rollDice;
                        }
                        else
                        {
                            position = 0;
                        }
                        Console.WriteLine("Player moved back to {0} position", position);
                        break;
                }
            }

        }
    }
}
