/* 
Task-1: Write code that validates integer input

-> Solution must include either do-while or while iteration.

-> Inside iteration block:
    - Must use Console.ReadLine() statement to obtain input from the user.
    - Must ensure that the input is a valid representation of an integer.
    - If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
    - Solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

 -> Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
 */

/* string? userInput;
string valueEntered = "";
int numValue = 0;
bool validInput = false;

Console.WriteLine("Enter a number between 5 and 10.");

do
{
    userInput = Console.ReadLine();

    if (userInput != null)
    {
        valueEntered = userInput;
    }

    validInput = int.TryParse(valueEntered, out numValue);
    {
        if (validInput == true)
        {
            if (numValue >= 5 && numValue <= 10)
            {
                validInput = true;
                Console.WriteLine($"Your input value ({numValue}) has been accepted.");
            }
            else
            {
                Console.WriteLine($"You entered ({numValue}). Please enter a number between 5 and 10.");
            }
        }
        else
        {
            Console.WriteLine("You have entered an Invalid Number, please try again.");
        }
    }
} while (validInput == false);

userInput = Console.ReadLine(); */


/* ------------------------------------------------------------------ */


/* 
Task-2: write code that validates string input

-> Your solution must include either a do-while or while iteration.

-> Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

-> Inside the iteration block:
    - Solution must use a Console.ReadLine() statement to obtain input from the user.
    - Solution must ensure that the value entered matches one of the three role options.
    - Solution should use the Trim() method on the input value to ignore leading and trailing space characters.
    - Solution should use the ToLower() method on the input value to ignore case.
    - If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

-> Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

/* string? userInput;
string userRole = "";
bool validInput = false;

Console.Write("Enter your role name (Administrator, Manager, or User): ");

do
{
    userInput = Console.ReadLine();
    if (userInput != null)
    {
        userRole = userInput.Trim();
    }

    if (userRole.ToLower() == "administrator" || userRole.ToLower() == "manager" || userRole.ToLower() == "user")
    {
        validInput = true;
        Console.WriteLine($"Your input value ({userRole}) has been accepted.");
    }
    else
    {
        Console.WriteLine($"User Role ({userRole}) is Invalid");
    }
} while (validInput == false); */

/* ------------------------------------------------------------------ */

/* 
Task-3: Write code that processes the contents of a string array

-> Solution must use the following string array to represent the input to your coding logic:
    - string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

-> Solution must declare an integer variable named 'periodLocation' that can be used to hold the location of the period character within a string.

-> Solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named 'myString'.

-> In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the 'myString' variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of '-1' will be returned.

-> Your solution must include an inner do-while or while loop that can be used to process the myString variable.

-> In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

-> In the inner loop, your solution must not display the period character.

-> In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/

string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}