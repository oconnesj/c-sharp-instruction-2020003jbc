using System;

namespace project_2_1_student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();
            string choice = "y";
            string Continue = "Press 'y' to continue or 'n' to exit: ";

            while (choice.Contains("y"))
            {

                string FirstName;
                string LastName;
                int BirthYear;
                Console.Write("Enter First Name: ");
                FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                LastName = Console.ReadLine();
                Console.Write("Enter Year of Birth: ");
                // convert string to int
                BirthYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                string Greeting = "Welcome " + FirstName + " " + LastName + "!";
                string TempPassword = "Your Temporary password is: " + LastName + "*" + BirthYear;
                Console.WriteLine(Greeting);
                Console.WriteLine(TempPassword);

                Console.WriteLine();
                Console.Write(Continue);
                choice = Console.ReadLine();
            }
        }
    }
}
