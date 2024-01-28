using System;
namespace ValidPositiveNumber;
class PositiveInteger{
public static void Main(string[] args){
        int userInput;

        do
        {
            Console.WriteLine("Enter a positive integer: ");
              userInput =Convert.ToInt32(Console.ReadLine());

            if ( userInput > 0)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }

        } while (true);

        Console.WriteLine($"You entered valid positive integer: {userInput}");

       
    }
}
