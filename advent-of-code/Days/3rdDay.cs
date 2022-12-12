using advent_of_code.Models;


namespace advent_of_code.Days
{
    internal class _3rdDay
    {
        readonly List<Rucksack> Rucksacks = new();

        public _3rdDay(string path) 
        {
            using var reader = new StreamReader(path);
            var stringResult = reader.ReadToEnd();
            var lines = stringResult.Split('\n');
            foreach (string sack in lines.Where(line => !string.IsNullOrEmpty(line)))
            {
                Rucksacks.Add(new Rucksack(sack));
            }
        }

        public int GetSumOfPriorities() => Rucksacks.Sum(rucksack => rucksack.GetRucksackPriority());

        public int GetSumOfGroupedElves()
        {
            int sum = 0;
            for (int i = 0; i < Rucksacks.Count - 2; i += 3)
            {
                char type = GetSameItems(Rucksacks[i], Rucksacks[i + 1], Rucksacks[i + 2]);
                sum += Rucksack.GetTypePriority(
                    type
                );
            }
            return sum;
        }

        char GetSameItems(Rucksack rucksack1, Rucksack rucksack2, Rucksack rucksack3)
        {
            var items1 = rucksack1.DistinctItems;
            var items2 = rucksack2.DistinctItems;
            var items3 = rucksack3.DistinctItems;

            while (items1.Any() || items2.Any() || items3.Any())
            {
                if (items1.Any()) {
                    if (items2.IndexOf(items1[0]) > -1 && items3.IndexOf(items1[0]) > -1)
                    {
                        return items1[0];
                    }
                    items1.RemoveAt(0);
                }
                if (items2.Any())
                {
                    if (items1.IndexOf(items2[0]) > -1 && items3.IndexOf(items2[0]) > -1)
                    {
                        return items2[0];
                    }
                    items2.RemoveAt(0);
                }
                if (items3.Any())
                {
                    if (items1.IndexOf(items3[0]) > -1 && items2.IndexOf(items3[0]) > -1)
                    {
                        return items3[0];
                    }

                    items3.RemoveAt(0);
                } 
            }

            throw new NotImplementedException("No comparten ninguna caraterística");
        }
    }
}
