using System;

namespace LeapYearChecker
{
    class Leap
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a day in a year: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if(day==366){
              Console.WriteLine("it is leap year");
            }
            else{
               Console.WriteLine("it is not leap year");
            }
        }
    }
}