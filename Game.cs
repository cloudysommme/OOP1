using System;

namespace Lab1
{
    internal class Game
    {
        public string OpponentName { get; }
        public bool Outcome { get; }
        public int RatingPlayed { get; }
        public int GameIndex { get; }
        public int GameId { get; }
        public int PlayerRatingBefore { get; }
        public int PlayerRatingAfter { get; }

        private static int lastID = 1;

        public Game(string opponentName, bool outcome, int ratingPlayed, int gameIndex, int playerRatingBefore, int playerRatingAfter)
        {
            OpponentName = opponentName;
            Outcome = outcome;
            RatingPlayed = ratingPlayed;
            GameIndex = gameIndex;
            GameId = lastID++; // Генерація унікального ідентифікатора гри
            PlayerRatingBefore = playerRatingBefore; 
            PlayerRatingAfter = playerRatingAfter; 
        }
    }
}
