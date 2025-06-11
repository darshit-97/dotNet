/* 
Exercise : Improve renewal rate of subscriptions

You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your Subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Your Subscription expires in 1 day!");
        discountPercentage = 20;
        Console.WriteLine($"Renew now and save {discountPercentage}%!");
    }
    else if (daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your Subscription expires in {daysUntilExpiration} days");
        discountPercentage = 10;
        Console.WriteLine($"Renew now and save {discountPercentage}%!");
    }
    else
    {
        Console.WriteLine("Your Subscription will expire soon. Renew Now!");
    }
}