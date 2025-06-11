/* 
you work in the security department of a company that matches online sellers with commission-based advertisers. You've been asked to write C# code that will iterate through the Order IDs of incoming orders. You need to inspect each Order ID to identify orders that may be fraudulent. You'll need to implement arrays to accomplish this programming task.

Your work in the security department is focused on finding a pattern for fraudulent orders. You want your code to review past customer orders and identify markers associated with fraudulent orders. Your company hopes the markers can be used to identify potential fraudulent purchase orders in the future before they're processed. Since you don't always know in advance how many orders you need to review, you can't create individual variables to hold each Order ID. How can you create a data structure to hold multiple related values?

In this exercise, you use arrays to store and analyze a collection of Order IDs.
*/


/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B123";
fraudulentOrderIDs[2] = "C123";
// fraudulentOrderIDs[3] = "D123";
*/

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "A100";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} Fraudulent Orders to process.");

/* 
you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship. In addition to the total number of finished products, you need to report the number of finished products stored in each individual bin in your warehouse, along with a running total. This running total will be used to create an audit trail so you can double-check your work and identify "shrinkage".
*/

/* string[] names = { "Rowena", "Helga", "Godric", "Salazar" };
foreach (string name in names)
{
    Console.WriteLine(name);
} */

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} (Running Total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");