namespace advent_of_code.Days
{
    internal class _4thDay
    {
        List<TupleElves> _elves = new();
        public _4thDay(string path)
        {
            using var reader = new StreamReader(path);
            var stringResult = reader.ReadToEnd();
            var lines = stringResult.Split('\n').Where(line => !string.IsNullOrEmpty(line));
            foreach (var line in lines)
            {
                var elfs = line.Split(',');
                _elves.Add(new TupleElves(elfs[0], elfs[1]));
            }
        }

        public int SumFullyContains => _elves.Sum(tuple => tuple.FullyOverlaps ? 1 : 0);
        public int SumPartiallyContains => _elves.Sum(tuple => tuple.PartiallyOverlaps ? 1 : 0);
    }

    class TupleElves
    {
        int lowerElfOne = 0;
        int upperElfOne = 0;
        int lowerElfTwo = 0;
        int upperElfTwo = 0;

        public TupleElves(string rangeElfOne, string rangeElfTwo)
        {
            var numbers1 = rangeElfOne.Split('-');
            lowerElfOne = int.Parse(numbers1[0]);
            upperElfOne = int.Parse(numbers1[1]);
            var numbers2 = rangeElfTwo.Split('-');
            lowerElfTwo = int.Parse(numbers2[0]);
            upperElfTwo = int.Parse(numbers2[1]);
        }

        public bool FullyOverlaps => (lowerElfOne <= lowerElfTwo && upperElfOne >= upperElfTwo) || (lowerElfTwo <= lowerElfOne && upperElfTwo >= upperElfOne);
        public bool PartiallyOverlaps => (lowerElfOne <= upperElfTwo && upperElfOne >= lowerElfTwo);
    }
}
