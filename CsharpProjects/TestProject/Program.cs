Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled a Triple! +6 bonus to total!");
        total += 6;
        Console.WriteLine($"Total after Bonus: {total}");
    }
    else
    {
        Console.WriteLine("You rolled a double! +2 Bonus to total!");
        total += 2;
        Console.WriteLine($"Total after Bonus: {total}");
    }
}

if (total >= 16)
{
    Console.WriteLine("Congratulations! You have WON a Brand New Car!!!");
}
else if (total >= 10)
{
    Console.WriteLine("Congratulations! You have WON a Brand New Laptop!!!");
}
else if (total == 7)
{
    Console.WriteLine("Jackpot! You Have WON A TRIP!!!");
}
else
{
    Console.WriteLine("You Have WON a Kitten!!");
}