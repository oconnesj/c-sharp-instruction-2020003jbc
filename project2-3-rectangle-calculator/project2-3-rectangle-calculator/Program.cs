using System;

namespace project2_3_rectangle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();
            string choice = "y";
            string Continue = "Press 'y' to continue or 'n' to exit: ";

            while (choice.Contains("y") || choice.Contains("Y")) ;
            {
                string lengthString = "Enter Length: ";
                string widthString =  "Enter Width:  ";
                string area =         "Area:         ";
                string perimeter =    "Perimeter:    ";

                Console.Write(lengthString);
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write(widthString);
                double width = Convert.ToDouble(Console.ReadLine());
                double areaNumber = length * width;
                double perimeterNumber = 2 * width + 2 * length;
                Console.WriteLine(area + areaNumber);
                Console.WriteLine(perimeter + perimeterNumber);
                Console.WriteLine();
                Console.WriteLine(Continue);
                choice = Console.ReadLine();


            }



        }
    }
}
