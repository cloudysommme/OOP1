using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class GameAccount
    {
        public string UserName { get; set; }
        private int currentrating=1;
        public int CurrentRating { get { return currentrating; } set {
                if (value < 1)
                {
                    currentrating = 1;
                }
                else { currentrating = value; }
            } }
        private int GamesCount { get { return gameHistory.Count; } }
        private List<Game> gameHistory;

        public GameAccount(string userName, int initialRating)
        {
            UserName = userName;
            CurrentRating = initialRating;
            gameHistory = new List<Game>();
        }

        public void PlayGame(GameAccount opponent, int rating, bool isWin)
        {
            if (isWin)
            {
                WinGame(opponent.UserName, rating);
            }
            else
            {
                LoseGame(opponent.UserName, rating);
            }
        }

        private void WinGame(string opponentName, int rating)
        {
            

            int playerRatingBefore = CurrentRating;
            CurrentRating += rating;

            

            // Додавання нового об'єкту Game до історії гри
            gameHistory.Add(new Game(opponentName, true, rating, GamesCount, playerRatingBefore, CurrentRating));
        }

        private void LoseGame(string opponentName, int rating)
        {
           

            int playerRatingBefore = CurrentRating;
            CurrentRating -= rating;

            

            // Додавання нового об'єкту Game до історії гри
            gameHistory.Add(new Game(opponentName, false, rating, GamesCount, playerRatingBefore, CurrentRating));
        }

        public void GetStats()
        {
            Console.WriteLine("Game History:");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Game ID                                 | User       | Opponent    | Outcome   | Rating Played | Rating Before | Rating After |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            foreach (var game in gameHistory)
            {
                Console.WriteLine($"| {game.GameId.ToString(),-40} | {this.UserName,-12} | {game.OpponentName,-12} | {game.Outcome,-9} | {game.RatingPlayed,-10} | {game.PlayerRatingBefore,-10} | {game.PlayerRatingAfter,-10} |");
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Player {this.UserName} Final Rating: {this.CurrentRating}\n");
        }

        
    }
}
