/* 
you work in the security department of a company that matches online sellers with commission-based advertisers. You've been asked to write C# code that will iterate through the Order IDs of incoming orders. You need to inspect each Order ID to identify orders that may be fraudulent. You'll need to implement arrays to accomplish this programming task.

Your work in the security department is focused on finding a pattern for fraudulent orders. You want your code to review past customer orders and identify markers associated with fraudulent orders. Your company hopes the markers can be used to identify potential fraudulent purchase orders in the future before they're processed. Since you don't always know in advance how many orders you need to review, you can't create individual variables to hold each Order ID. How can you create a data structure to hold multiple related values?

In this exercise, you use arrays to store and analyze a collection of Order IDs.
*/
string[] fraudulentOrderIDs = new string[3];