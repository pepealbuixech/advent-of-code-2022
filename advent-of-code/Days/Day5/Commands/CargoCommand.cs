using System;
namespace advent_of_code.Days.Day5.Commands
{
    public interface CargoCommand
    {
        public void Execute(Dictionary<int, Stack<char>> stacks);
    }
}

