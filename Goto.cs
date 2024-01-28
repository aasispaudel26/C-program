using System;
namespace GotoSpecificLable;
class Goto
{
    static void Main()
    {
        int userInput;

        Console.WriteLine("Enter a number:");

        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            // Using goto to demonstrate control flow. 
            
            if (userInput % 2 == 0)
                goto EvenLabel;
            else
                goto OddLabel;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            goto EndLabel;
        }

        // Code block for even number
    EvenLabel:
        Console.WriteLine($"{userInput} is an even number.");
        goto EndLabel;

        // Code block for odd number
    OddLabel:
        Console.WriteLine($"{userInput} is an odd number.");

    EndLabel:
        Console.WriteLine("Program execution completed.");
    }
}
