using System;
namespace advent_of_code.Days.Day5.Commands
{
    class MoveCargoCommand : CargoCommand
    {
        public int Quantity { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        public void Execute(Dictionary<int, Stack<char>> stacks)
        {
            for (int i = 0; i < Quantity; i++)
            {
                stacks[To].Push(stacks[From].Pop());
            }
        }
    }
}

