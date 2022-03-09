
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
        public static int PlayerTurns()
        {
            int position = 0;
            int rollDice = RollDice();

            int checkOption = new Random().Next(0, 3);
            switch (checkOption)    //Player checks an option
            {   // No play
                case 0:
                    position += 0;
                    break;
                // Ladder
                case 1:
                    int rollAgain = RollDice();
                    position += rollAgain;
                    break;
                // Snake bite
                case 2:
                    if (position > 0)
                    {
                        position -= rollDice;
                    }
                    break;
            }
            return position;
        }

        public void CheckWin()
        {
            while (_playerOnePos <= 100 && _playerTwoPos <= 100)
            {
                int playerOne = PlayerTurns();
                int nextPosOne = _playerOnePos + playerOne;
                if (_playerOnePos == 100)
                {
                    Console.WriteLine("Player One wins");
                    break;
                }

                else if (nextPosOne <= 100)
                {
                    _playerOnePos += playerOne;
                }
                int playerTwo = PlayerTurns();
                int nextPosTwo = _playerOnePos + playerTwo;

                if (_playerTwoPos == 100)
                {
                    Console.WriteLine("Player two wins");
                    break;
                }

                else if (nextPosTwo <= 100)
                {
                    _playerTwoPos += PlayerTurns();
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

