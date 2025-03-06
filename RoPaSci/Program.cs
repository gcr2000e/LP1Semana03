using System;

namespace RoPaSci
{
    class Program
    {
        enum GameItem
        {
            Rock,
            Paper,
            Scissors
        }

        enum GameStatus
        {
            Draw,
            Player1Wins,
            Player2Wins
        }

        private static void Main(string[] args)
        {
            GameItem player1 = Enum.Parse<GameItem>(args[0], true);
            GameItem player2 = Enum.Parse<GameItem>(args[1], true);
            GameStatus result = RockPaperScissors(player1, player2);
            Console.WriteLine(result);
        }

        private static GameStatus RockPaperScissors
        (GameItem player1, GameItem player2)
        {
            return player1 == player2 ? GameStatus.Draw :
            (player1 == GameItem.Rock && player2 == GameItem.Scissors) ||
               (player1 == GameItem.Paper && player2 == GameItem.Rock) ||
               (player1 == GameItem.Scissors && player2 == GameItem.Paper)
               ? GameStatus.Player1Wins : GameStatus.Player2Wins;
        }
    }
}
