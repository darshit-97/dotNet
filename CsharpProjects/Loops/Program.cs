/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int j = 0; j < names.Length; j++)
    if (names[j] == "David") names[j] = "Sammy";

foreach (var name in names) Console.WriteLine(name); */

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}