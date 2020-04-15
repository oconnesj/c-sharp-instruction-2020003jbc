using System;

namespace Project_2_2_GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Letter Grade Converter");
            Console.WriteLine();
            string choice = "y";
            string Continue = "Press 'y' to continue or 'n' to exit: ";

            while (choice.Contains("y"))
            {


                int EnterGrade;
                String GradeMessage = "Letter grade: ";
                Console.Write("Enter numerical grade: ");
                EnterGrade = Convert.ToInt32(Console.ReadLine());
                if (EnterGrade > 100)
                {
                    Console.WriteLine("Enter a value less than or equal to 100");
                    Console.WriteLine();
                    continue;
                }
                else if (EnterGrade < 0)
                {
                    Console.WriteLine("Enter a value larger than 0");
                    Console.WriteLine();
                    continue;
                }
                if (EnterGrade >= 88 )//&& EnterGrade <= 100)


                {
                    Console.WriteLine(GradeMessage + "A");
                    

                }
                else if (EnterGrade >= 80)
                {
                    Console.WriteLine(GradeMessage + "B");
                }
                else if (EnterGrade >= 67)
                {
                    Console.WriteLine(GradeMessage + "C");
                }
                else if (EnterGrade <= 66 && EnterGrade >= 60)
                    Console.WriteLine(GradeMessage + "D");
                else Console.WriteLine(GradeMessage + "F");
                Console.WriteLine();
                Console.Write(Continue);
                choice = Console.ReadLine();
            }
        }
    }
}



