namespace advent_of_code.Days
{
    internal class _5thDay
    {
        public _5thDay(string path)
        {
            using var reader = new StreamReader(path);
            var stringResult = reader.ReadToEnd();
            var lines = stringResult.Split('\n');
            int blankLineIndex;
            Dictionary<int,Stack<char>> stacks = new();
            
            //Find divior line
            for (blankLineIndex = 0; blankLineIndex < lines.Length; blankLineIndex++)
            {
                if (string.IsNullOrEmpty(lines[blankLineIndex]))
                {
                    break;
                }
            }

            var head = lines[..(blankLineIndex-1)];
            var commands = lines[(blankLineIndex+1)..(lines.Length-1)];
            foreach(var character in lines[blankLineIndex-1].Split(' ').Where(c => c != ""))
            {
                stacks.Add(int.Parse(character), new());
            }

            foreach (var line in head.Reverse())
            {
                foreach (var key in stacks.Keys)
                {
                    var value = line[key * 4 - 3];
                    if (char.IsWhiteSpace(value)) continue;
                    stacks[key].Push(value);
                }
            }

            foreach (var command in commands)
            {
                StackCommandFactory.FromLine(command).DoCommand(stacks);
            }

            foreach (var values in stacks.Values)
            {
                Console.Write(values.Peek());
            }
        }

        class StackCommandFactory
        {
            public static StackCommand FromLine(string line)
            {
                var arguments = line.Split(' ');
                switch (arguments[0])
                {
                    case "move":
                        return new MoveCommand()
                        {
                            Quantity = int.Parse(arguments[1]),
                            From = int.Parse(arguments[3]),
                            To = int.Parse(arguments[5]),
                        };
                    default: throw new NotImplementedException();
                }

            }
        }

        public interface StackCommand
        {
            public void DoCommand(Dictionary<int,Stack<char>> stacks);
        }

        class MoveCommand: StackCommand
        {
            public int Quantity { get; set; }
            public int From { get; set; }
            public int To { get; set; }

            public void DoCommand(Dictionary<int, Stack<char>> stacks)
            {
                for (int i = 0; i < Quantity; i++)
                {
                    stacks[To].Push(stacks[From].Pop());
                }
            }
        }
    }
}
