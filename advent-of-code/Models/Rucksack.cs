namespace advent_of_code.Models
{
    internal class Rucksack
    {
        const int INT_CODE_a = 97;
        const int INT_CODE_A = 65;
        readonly string CompartmentA;
        readonly string CompartmentB;

        public List<char> DistinctItems { get; }

        public Rucksack(string content)
        {
            var compartmentSize = content.Length / 2;
            DistinctItems = content.Distinct().Order().ToList();
            CompartmentA = content[..compartmentSize];
            CompartmentB = content[compartmentSize..];
        }

        char GetRucksackType()
        {
            var compA = CompartmentA;
            var compB = CompartmentB;
            while (compA.Length > 0)
            {
                if (compB.IndexOf(compA[0]) > -1) return compA[0];
                if (compA.IndexOf(compB[0]) > -1) return compB[0];
                compA = compA[1..];
                compB = compB[1..];
            }
            throw new NotImplementedException("Need to implement an exception with the no one");
        }

        public int GetRucksackPriority()
        {
            var type = GetRucksackType();
            return GetTypePriority(type);
        }

        public static int GetTypePriority(char type)
        {
            var code = (int)type;
            if (code >= INT_CODE_a) return code - INT_CODE_a + 1;
            return code - INT_CODE_A + 27;
        }
    }
}
