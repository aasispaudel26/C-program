using System;

namespace SumOfFirst100Integers
{
    class Positive
    {
        static void Main(String[] args)
        {
         
            int sum = 0;

          
            for (int i = 1; i <= 100; i++)
            {
                sum += i; 
            }

            // Display the result
            Console.WriteLine($"The sum of the first 100 positive integers is: {sum}");
        }
    }
}

