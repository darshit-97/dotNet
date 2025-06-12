bool flag = true;
int value = 0;
if (flag)
{
    Console.WriteLine($"Inside the Code Block:{value}");
}

value = 10;
Console.WriteLine($"Outside the Code Block:{value}");

/* ----------------------------------------------------------- */

int value1 = 5;
if (value1 > 0)
{
    int value2 = 6;
    value1 += value2;
}

Console.WriteLine(value1);

/* ----------------------------------------------------------- */

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");