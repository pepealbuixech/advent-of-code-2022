using System;

namespace advent_of_code.Days.Day6
{
	public class _6thDay2016
	{
		public _6thDay2016(string errorCorrectionPath)
		{
			using var reader = new StreamReader(errorCorrectionPath);
			this.ErrorCorrectionInput = reader.ReadToEnd().Split('\n').Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        public string? CorrectSignalWithMostCommon()
        {
            if (this.ErrorCorrectionInput.Length == 0)
            {
                return null;
            }
            Dictionary<char, int>[] repetitions = LoadDictionary();

            var response = "";
            foreach (var column in repetitions)
            {
                response += column.Where(x => x.Value == column.Values.Max()).Select(key => key.Key).First();
            }
            return response;
        }

        public string? CorrectSignalWithLessCommon()
        {
            if (this.ErrorCorrectionInput.Length == 0)
            {
                return null;
            }
            Dictionary<char, int>[] repetitions = LoadDictionary();

            var response = "";
            foreach (var column in repetitions)
            {
                response += column.Where(x => x.Value == column.Values.Min()).Select(key => key.Key).First();
            }
            return response;
        }


        private Dictionary<char, int>[] LoadDictionary()
        {
            Dictionary<char, int>[] repetitions = new Dictionary<char, int>[this.ErrorCorrectionInput[0].Length];
            foreach (var input in this.ErrorCorrectionInput)
            {
                for (int j = 0; j < repetitions.Length; j++)
                {
                    if (repetitions[j] is null)
                    {
                        repetitions[j] = new();
                    }
                    if (repetitions[j].TryGetValue(input[j], out int value))
                    {
                        repetitions[j][input[j]] += 1;
                    }
                    else
                    {
                        repetitions[j].Add(input[j], 1);
                    }
                }
            }

            return repetitions;
        }

        public string[] ErrorCorrectionInput { get; }
    }
}

