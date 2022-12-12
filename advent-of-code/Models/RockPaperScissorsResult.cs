namespace advent_of_code.Models
{
    internal class RockPaperScissorsResult: IComparable
    {
        public const string ROCK = "A";
        public const string PAPER = "B";
        public const string SCISSORS = "C";

        public string Move;

        public RockPaperScissorsResult(string move)
        {
            Move = move switch
            {
                ROCK or "X" => ROCK,
                PAPER or "Y" => PAPER,
                SCISSORS or "Z" => SCISSORS,
                _ => throw new NotImplementedException()
            };
        }

        public string Counter()
        {
            return Counter(Move);
        }

        public string Wins() {
            return Move switch
            {
                ROCK => SCISSORS,
                PAPER => ROCK,
                SCISSORS => PAPER,
                _ => throw new ArgumentException($"Move {Move} is not valid"),
            };
        }

        public static string Counter(string move)
        {
            return move switch
            {
                ROCK => PAPER,
                PAPER => SCISSORS,
                SCISSORS => ROCK,
                _ => throw new ArgumentException($"Move {move} is not valid"),
            };
        }

        public int CompareTo(object? obj)
        {

            if (obj is RockPaperScissorsResult result)
            {
                if (result.Move == this.Move)
                {
                    return 0;
                }
                if (result.Move == this.Counter())
                {
                    return -1;
                }
                return 1;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int GetMovePoints()
        {
            return Move switch {
                ROCK => 1,
                PAPER => 2,
                SCISSORS => 3,
                _ => throw new NotImplementedException()
            };
        }
    }
}
