using advent_of_code.Models;

namespace advent_of_code.Days
{
    internal class _2ndDay
    {
        public List<RockPaperScissorsGame> Games;

        public _2ndDay(string path) 
        {
            using var reader = new StreamReader(path);
            var stringResult = reader.ReadToEnd();
            var lines = stringResult.Split('\n');
            Games = new List<RockPaperScissorsGame>();
            foreach (string game in lines)
            {
                if (string.IsNullOrEmpty(game)) continue;
                var cols = game.Split(" ");
                Games.Add(new RockPaperScissorsGame(cols[0], cols[1]));
            }
        }


        public int TotalScore => Games.Sum(game => game.FirstHelpPoints());
        public int Score => Games.Sum(game => game.SeccondHelpPoints());
    }
}
