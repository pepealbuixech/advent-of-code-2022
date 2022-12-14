using System;
namespace advent_of_code.Days.Day6
{
	public class _6thDay
	{
        public string Signal { get; }

		public _6thDay(string path)
		{
			using var reader = new StreamReader(path);
			this.Signal = reader.ReadToEnd();
		}

		public int GetFirstMarker(int packageLength = 4)
		{
			for (int i = 0; i < this.Signal.Length - (packageLength - 1); i++)
            {
                var signal = this.Signal.Substring(i, packageLength);
                if (!HasRepeatedCharacters(signal))
                {
                    return i + packageLength;
                }
            }
            return -1;
        }

        private static bool HasRepeatedCharacters(string signal)
        {
            while (signal.Length > 1)
            {
                var firstCharacter = signal[0];
                signal = signal[1..];
                if (signal.IndexOf(firstCharacter) > -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

