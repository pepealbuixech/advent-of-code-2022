namespace advent_of_code.Days.Day5
{
    using advent_of_code.Days.Day5.Commands;
    public class _5thDay
    {
        public Dictionary<int,Stack<char>> CrateStacks { get; private set; }
        private string[] _commands;
        private string[] _head;
        public string _stacks;

        public _5thDay(string path)
        {
            using var reader = new StreamReader(path);
            var stringResult = reader.ReadToEnd();
            var lines = stringResult.Split('\n');
            int blankLineIndex;
            
            //Find divior line
            for (blankLineIndex = 0; blankLineIndex < lines.Length; blankLineIndex++)
            {
                if (string.IsNullOrEmpty(lines[blankLineIndex]))
                {
                    break;
                }
            }

            _head = lines[..(blankLineIndex-1)];         
            _commands = lines[(blankLineIndex+1)..(lines.Length-1)];
            _stacks = lines[blankLineIndex - 1];
        }

        public _5thDay ExecuteWithCargo9000()
        {
            foreach (var command in _commands)
            {
                Cargo9000CommandFactory.FromLine(command).Execute(CrateStacks);
            }
            return this;
        }

        public _5thDay ExecuteWithCargo9001()
        {
            foreach (var command in _commands)
            {
                Cargo9001CommandFactory.FromLine(command).Execute(CrateStacks);
            }
            return this;
        }

        public _5thDay LoadInitialState()
        {
            CrateStacks = new();
            foreach (var character in _stacks.Split(' ').Where(c => c != ""))
            {
                CrateStacks.Add(int.Parse(character), new());
            }

            foreach (var line in _head.Reverse())
            {
                foreach (var key in CrateStacks.Keys)
                {
                    var value = line[key * 4 - 3];
                    if (char.IsWhiteSpace(value)) continue;
                    CrateStacks[key].Push(value);
                }
            }
            return this;
        }

        public string GetStackState()
        {
            var state = "";
            foreach (var stack in CrateStacks.Values)
            {
                state += stack.Peek();
            }
            return state;
        }
    }
}
