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

// Random coin = new();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "Heads" : "Tails");

/* Method 2 */

Random coin = new();
Console.WriteLine((coin.Next(0, 2) == 0) ? "Heads" : "Tails");