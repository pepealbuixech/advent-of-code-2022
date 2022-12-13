using advent_of_code.Days;
using advent_of_code.Days.Day5;

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

Console.WriteLine("------------------------------------\n------------ fifth day ------------\n------------------------------------");
var fifthhDay = new _5thDay("input5.txt");
Console.WriteLine($"Moving with cargo 9000 {fifthhDay.LoadInitialState().ExecuteWithCargo9000().GetStackState()}");
Console.WriteLine($"Moving with cargo 9001 {fifthhDay.LoadInitialState().ExecuteWithCargo9001().GetStackState()}");
//Console.WriteLine($"Partially contains {forthDay.SumPartiallyContains}");