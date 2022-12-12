namespace advent_of_code.Models
{
    using System.Linq;

    internal class Elf
    {
        public int Id { get; }
        public List<int> Snacks { get; }
        public Elf(int id)
        {
            Id = id;
            Snacks = new List<int>();
        }

        public void AddSnack(int calories) => Snacks.Add(calories);
        public int TotalCalories => Snacks.Sum();
        public override string ToString() => $"Elf {Id} with {TotalCalories} calories";
    }
}
