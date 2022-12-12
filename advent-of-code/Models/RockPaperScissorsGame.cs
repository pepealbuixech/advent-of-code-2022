namespace advent_of_code.Models
{
    internal class RockPaperScissorsGame
    {
        public RockPaperScissorsResult Result1 { get; }
        public RockPaperScissorsResult FirstHelp { get; }
        public RockPaperScissorsResult SeccondHelp { get; }


        public RockPaperScissorsGame(string result1, string result2)
        {
            Result1 = new RockPaperScissorsResult(result1);
            FirstHelp = new RockPaperScissorsResult(result2);
            SeccondHelp = result2 switch
            {
                "X" => new RockPaperScissorsResult(Result1.Wins()),
                "Y" => Result1,
                "Z" => new RockPaperScissorsResult(Result1.Counter()),
                _ => throw new NotImplementedException()
            };
        }

        public int FirstHelpPoints()
        {
            var compareTo = Result1.CompareTo(FirstHelp);
            if (compareTo > 0)
            {
                return FirstHelp.GetMovePoints();
            }

            if (compareTo == 0)
            {
                return 3 + FirstHelp.GetMovePoints();
            }

            return 6 + FirstHelp.GetMovePoints() ;
        }

        public int SeccondHelpPoints()
        {
            var compareTo = Result1.CompareTo(SeccondHelp);
            if (compareTo > 0)
            {
                return SeccondHelp.GetMovePoints();
            }

            if (compareTo == 0)
            {
                return 3 + SeccondHelp.GetMovePoints();
            }

            return 6 + SeccondHelp.GetMovePoints();
        }

    }
}
