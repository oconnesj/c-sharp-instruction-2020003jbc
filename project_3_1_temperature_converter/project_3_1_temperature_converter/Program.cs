using System;

namespace project_3_1_temperature_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();
            string choice = "y";
            string Continue = "Press 'y' to continue or 'n' to exit: ";

            while (choice.Contains("y"))
            {
                double inputF;
                double outputC;
                Console.Write("Enter degress in Fahrenheit: ");
                inputF = Convert.ToDouble(Console.ReadLine());
                outputC = (inputF - 32) * 5 / 9;
                Console.WriteLine("Degress in Celsius: " + Math.Round(outputC, 2));
                Console.WriteLine();
                Console.Write(Continue);
                choice = Console.ReadLine();
                Console.WriteLine("Bye");

            }
        }
    }
}