using System;

namespace advent_of_code.Days.Day5.Commands
{
	public class Move9001CargoCommand: CargoCommand
	{
        public int Quantity { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        public void Execute(Dictionary<int, Stack<char>> stacks)
        {
            var moves = stacks[From].Take(Quantity).ToArray();
            for (int i = moves.Length - 1; i >= 0; i--)
            {
                stacks[From].Pop();
                stacks[To].Push(moves[i]);
            }
        }
    }
}

