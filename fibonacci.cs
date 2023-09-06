void addNumber(List<int> numbers)
{
    var last = numbers[numbers.Count - 1];
    var secondtolast = numbers[numbers.Count - 2];
    numbers.Add(last + secondtolast);
}

var fibonacciNumbers = new List<int> {1, 1};

for (int i = 0; i < 18; i++)
{
    addNumber(fibonacciNumbers);
}
foreach(var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}
