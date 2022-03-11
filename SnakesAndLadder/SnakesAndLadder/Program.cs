
using System;

namespace SnakesAndLadder
{
    public class SnakesAndLadders
    {
        private int _playerOnePos = 0;
        private int _playerTwoPos = 0;
        public static int RollDice()
        {
            return new Random().Next(1, 7);
        }
        public static int PlayerTurns(int Position)
        {
            int rollDice = RollDice();
            int checkOption = new Random().Next(0, 3);
            switch (checkOption)    //Player checks an option
            {   // No play
                case 0:
                    Position += 0;
                    break;
                // Ladder
                case 1:
                    int rollAgain = RollDice();
                    int currentPos = Position + rollAgain;
                    if (currentPos <= 100)
                    {
                        Position += rollAgain;
                    }
                    break;
                // Snake bite
                case 2:
                    if (Position > 0)
                    {
                        Position -= rollDice;
                    }
                    break;
            }
            return Position;
        }

        public void CheckWin()
        {
            while (_playerOnePos != 100 && _playerTwoPos != 100)
            {
                //Player One
                int playerOne = PlayerTurns(_playerOnePos);
                _playerOnePos = playerOne;

                if (_playerOnePos == 100)
                {
                    Console.WriteLine("Player One wins");
                    break;
                }

                // Player Two
                int playerTwo = PlayerTurns(_playerTwoPos);
                _playerTwoPos = playerTwo;

                if (_playerTwoPos == 100)
                {
                    Console.WriteLine("Player Two wins");
                    break;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SnakesAndLadders winner = new SnakesAndLadders();
            winner.CheckWin();
        }
    }
}

