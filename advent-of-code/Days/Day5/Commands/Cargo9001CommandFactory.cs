using System;
namespace advent_of_code.Days.Day5.Commands
{
	public class Cargo9001CommandFactory
	{
        public static CargoCommand FromLine(string line)
        {
            var arguments = line.Split(' ');
            switch (arguments[0])
            {
                case "move":
                    return new Move9001CargoCommand
                    {
                        Quantity = int.Parse(arguments[1]),
                        From = int.Parse(arguments[3]),
                        To = int.Parse(arguments[5]),
                    };
                default: throw new NotImplementedException();
            }

        }
    }
}

