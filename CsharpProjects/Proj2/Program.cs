/* 
Code challenge - Report the Order IDs that need further investigation
Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.

Use the following steps to complete this challenge.

1. Declare an array and initialize it to contain the following elements:
    B123
    C234
    A345
    C15
    B177
    G3003
    C235
    B179

2. Create a foreach statement to iterate through each element of your array.
3. Report the Order IDs that start with the letter "B".
*/

string[] OrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string ID in OrderIDs)
{
    if (ID.StartsWith("B"))
    {
        Console.WriteLine(ID);
    }
}