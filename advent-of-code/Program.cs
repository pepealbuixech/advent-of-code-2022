using advent_of_code.Days;
using advent_of_code.Days.Day5;
using advent_of_code.Days.Day6;

//Console.WriteLine("------------------------------------\n------------ first day -------------\n------------------------------------");
//var firstDay = new _1stDay("input1.txt");
//firstDay.GetMaxResult();
//firstDay.GetThreeMaxResults();


//Console.WriteLine("------------------------------------\n------------ second day ------------\n------------------------------------");
//var secondDay = new _2ndDay("input2.txt");
//Console.WriteLine($"Total score RPS {secondDay.TotalScore}");
//Console.WriteLine($"New Total score RPS {secondDay.Score}");

//Console.WriteLine("------------------------------------\n------------ third day ------------\n------------------------------------");
//var thirdDay = new _3rdDay("input3.txt");
//Console.WriteLine($"Total of priorities {thirdDay.GetSumOfPriorities()}");
//Console.WriteLine($"Total of grouped priorities {thirdDay.GetSumOfGroupedElves()}");

//Console.WriteLine("------------------------------------\n------------ fourth day ------------\n------------------------------------");
//var forthDay = new _4thDay("input4.txt");
//Console.WriteLine($"Fully contains {forthDay.SumFullyContains}");
//Console.WriteLine($"Partially contains {forthDay.SumPartiallyContains}");

//Console.WriteLine("------------------------------------\n------------ fifth day ------------\n------------------------------------");
//var fifthhDay = new _5thDay("input5.txt");
//Console.WriteLine($"Moving with cargo 9000 {fifthhDay.LoadInitialState().ExecuteWithCargo9000().GetStackState()}");
//Console.WriteLine($"Moving with cargo 9001 {fifthhDay.LoadInitialState().ExecuteWithCargo9001().GetStackState()}");

Console.WriteLine("------------------------------------\n------------ sixth day ------------\n------------------------------------");
//var sixthDay2016 = new _6thDay2016("input6_correct_signal.txt");
//Console.WriteLine("Ejercicios 2016-6");
//Console.WriteLine($"Corrected signal with most common character {sixthDay2016.CorrectSignalWithMostCommon()}");
//Console.WriteLine($"Corrected signal with less common character {sixthDay2016.CorrectSignalWithLessCommon()}");

var sixthDay = new _6thDay("input6.txt");
Console.WriteLine($"First marker was at position {sixthDay.GetFirstMarker()}");
Console.WriteLine($"First marker 14 length was at position {sixthDay.GetFirstMarker(14)}");