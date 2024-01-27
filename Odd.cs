using System;

namespace OddNumbersExcludingFive
{
    class Odd
    {
        static void Main(String[] args)
        {
            // Use a for loop to iterate through numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                // Skip the number 5 using the continue statement
                if (i == 5)
                {
                    continue;
                }

                // Check if the current number is odd
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
