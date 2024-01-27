using System;

namespace DayChecker
{
    class Switch
    {
        static void Main(String[] args)
        {
            // Get input from the user
            Console.WriteLine("Enter a day of the week: ");
            string day =Convert.ToString(Console.ReadLine());

      
            day = day.ToLower();

            // Use a switch statement to check the day of the week
            string message;

            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    message = "It's a weekday.";
                    break;

                case "saturday":
                case "sunday":
                    message = "It's the weekend.";
                    break;

                default:
                    message = "Invalid day of the week.";
                    break;
            }

            // Display the result
            Console.WriteLine(message);
        }
    }
}
