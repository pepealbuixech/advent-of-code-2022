using advent_of_code.Models;

namespace advent_of_code.Days
{
    internal class _1stDay
    {
        private string[]? _list;
        public string[] List => GetStringList();
        public string Path { get; }

        public _1stDay(string path)
        {
            Path = path;
        }

        private string[] GetStringList()
        {
            if (_list is null)
            {
                using var reader = new StreamReader(Path);
                var stringResult = reader.ReadToEnd();
                _list = stringResult.Split('\n') ?? Array.Empty<string>();
            }
            return _list;

        }

        public void GetMaxResult()
        {
            var counter = 0;
            var max = 0;
            for (int i = 0; i < List.Length; i++)
            {
                try
                {
                    int value = int.Parse(List[i]);
                    counter += value;
                }
                catch (FormatException)
                {
                    if (counter > max)
                    {
                        max = counter;
                    }
                    counter = 0;
                }
            }
            if (counter > max)
            {
                max = counter;
            }
            Console.WriteLine("the maximum result is {0}", max);

        }

        public void GetThreeMaxResults()
        {
            SortedDictionary<int, List<Elf>> sortedElfs = GetSortedElfs(List);

            try
            {
                int i = 0;
                int total = 0;
                foreach (var el in sortedElfs.Reverse())
                {
                    foreach (var elf in el.Value)
                    {
                        Console.WriteLine(elf.ToString());
                        total += elf.TotalCalories;
                        if (++i == 3)
                        {
                            Console.WriteLine("Total calories {0}", total);
                            return;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("No hay suficientes elfos");
            }

        }

        static SortedDictionary<int, List<Elf>> GetSortedElfs(string[] list)
        {
            var sortedElfs = new SortedDictionary<int, List<Elf>>();
            var currentElf = new Elf(1);
            for (int i = 0; i < list.Length; i++)
            {
                try
                {
                    currentElf.AddSnack(int.Parse(list[i]));
                }
                catch (FormatException)
                {
                    sortedElfs.TryGetValue(currentElf.TotalCalories, out var selectedElfs);
                    sortedElfs.Remove(currentElf.TotalCalories);
                    if (selectedElfs is null)
                    {
                        selectedElfs = new List<Elf>();
                    }
                    selectedElfs.Add(currentElf);
                    sortedElfs.Add(currentElf.TotalCalories, selectedElfs);
                    currentElf = new Elf(currentElf.Id + 1);
                }
            }

            return sortedElfs;
        }
    }
}

