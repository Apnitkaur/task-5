using System;

namespace task_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

   
        {
            try
            {
                Console.WriteLine("Enter marks for Maths: ");
                int mathsMarks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter marks for Physics: ");
                int physicsMarks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter marks for Chemistry: ");
                int chemistryMarks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter marks for Computer Science: ");
                int computerScienceMarks = Convert.ToInt32(Console.ReadLine());

                double averageMarks = CalculateAverage(mathsMarks, physicsMarks, chemistryMarks, computerScienceMarks);
                Console.WriteLine("Average marks: " + averageMarks);

                char grade = GetGrade(averageMarks);
                PrintRemarks(grade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static double CalculateAverage(int mathsMarks, int physicsMarks, int chemistryMarks, int computerScienceMarks)
        {
            int totalMarks = mathsMarks + physicsMarks + chemistryMarks + computerScienceMarks;
            double averageMarks = totalMarks / 4.0;
            return averageMarks;
        }

        static char GetGrade(double averageMarks)
        {
            char grade;
            if (averageMarks >= 80)
                grade = 'A';
            else if (averageMarks >= 70)
                grade = 'B';
            else if (averageMarks >= 60)
                grade = 'C';
            else if (averageMarks >= 50)
                grade = 'D';
            else
                grade = 'F';

            return grade;
        }

        static void PrintRemarks(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case 'B':
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case 'D':
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case 'F':
                    Console.WriteLine("Fail. Your grade is F");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}



