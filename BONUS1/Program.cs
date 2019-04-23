using System;

namespace BONUS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = String.Empty;            
            bool again = false;
            int grade = 0;

            Console.WriteLine("Welcome to the Letter Grade Converter!");

            do
            {

                Console.Write("\nEnter a numerical grade: ");
                grade = GetValidGrade();
                Console.WriteLine("Letter Grade: " + GetLetterGrade(grade));
                
                
                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine().ToUpper();
                if (choice[0] == 'Y')
                {
                    again = true;
                }
                else
                {
                    again = false;
                }

            } while (again == true);



        }

        private static int GetValidGrade()
        {
            string input = String.Empty;
            int num = 0;
            bool success = false;

            do
            {
                input = Console.ReadLine();
                success = int.TryParse(input, out num);
                if (!success || num > 100 || num < 0)
                {
                    Console.Write("Please enter a valid number grade (no decimals): ");
                    success = false;
                }
                else
                {
                    success = true;
                }
            } while (success == false);

            return num;
        }

        private static string GetLetterGrade(int grade)
        {
            switch (grade)
            {
                case int n when (n > 97):
                    return "A+";
                case int n when (n <= 97 && n > 92):
                    return "A";
                case int n when (n <= 92 && n > 87):
                    return "A-";
                case int n when (n <= 87 && n > 85):
                    return "B+";
                case int n when (n <= 85 && n > 82):
                    return "B";
                case int n when (n <= 82 && n > 79):
                    return "B-";
                case int n when (n <= 79 && n > 75):
                    return "C+";
                case int n when (n <= 75 && n > 70):
                    return "C";
                case int n when (n <= 70 && n > 66):
                    return "C-";
                case int n when (n <= 66 && n > 64):
                    return "D+";
                case int n when (n <= 64 && n > 62):
                    return "D";
                case int n when (n <= 62 && n > 59):
                    return "D-";
                case int n when (n <= 59 && n >= 0):
                    return "F";
                default:
                    return "";
            }
        }
    }
}
