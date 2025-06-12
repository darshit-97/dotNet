/* 
Conditional operator challenge
In this challenge, you'll implement a conditional operator to simulate a "coin flip". The resulting decision logic will display either heads or tails.

1. Use the Random class to generate a value.
2. Consider the range of numbers that is required.
3. Based on the value generated, use the conditional operator to display either heads or tails.
4. There should be a 50% chance that the result is either heads or tails.
5. Your code should be easy to read, but with as few lines as possible.
6. You should be able to accomplish the desired result in three lines of code
*/

/* Method 1 */

Random coin = new();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "Heads" : "Tails");

/* Method 2 */

Random coin2 = new();
Console.WriteLine((coin2.Next(0, 2) == 0) ? "Heads" : "Tails");

/* 
Decision logic challenge

In this challenge, you'll implement decision logic based on a series of business rules. The business rules specify the access that will be granted to users based on their role-based permissions and their career level. Code branches will display a different message to the user depending on their permissions and level.

User Access Rules Summary:
 - Admin users:
   - Level > 55: "Welcome, Super Admin user."
   - Level <= 55: "Welcome, Admin user."
 - Manager users:
   - Level >= 20: "Contact an Admin for access."
   - Level < 20: "You do not have sufficient privileges."
 - All other users: "You do not have sufficient privileges." 
*/
Random permission = new();
Random number = new();

string randomPermisson = permission.Next(1, 3) == 1 ? "Admin" : "Manager";
int level = number.Next(0, 100);

Console.WriteLine($"Permission: {randomPermisson}\nLevel: {level}");

if (randomPermisson.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin User.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin User.");
    }
}
else if (randomPermisson.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for Access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}