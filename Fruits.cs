using System;

namespace FruitArrayExample
{
    class Fruits
    {
        static void Main(String[]args)
        {
            // Create an array of string containing names of fruits
            string[] fruits = { "Apple", "Banana", "Orange", "Grapes", "Strawberry" };

            // Use a foreach loop to iterate through the array and display each fruit
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
