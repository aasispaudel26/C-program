using System;

namespace GradingSystem
{
    class Grade
    {
        static void Main(String[] args)
        {
            // Get input from the user
            Console.WriteLine("Enter the student's score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            if (score >= 90 & score<=100)
            {
                Console.WriteLine("you got grade A");
            }
            else if (score >= 80 & score<90)
            {
               Console.WriteLine("you got grade B");
            }
            else if (score >= 70 & score<80)
            {
                Console.WriteLine("you got grade C");
            }
            else if (score >= 60 & score<70)
            {
                Console.WriteLine("you got grade D");
                
            }
            else if (score >= 50 & score<60)
            {
                Console.WriteLine("you got grade E ");
                
            }
            else
            {
                Console.WriteLine("you got fail ");
                
            }

            
    }
}
}