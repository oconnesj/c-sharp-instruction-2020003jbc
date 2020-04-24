using System;

namespace project_4_3_tip_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator");
            Console.WriteLine();
            string choice = "y";
            string Continue = "Press 'y' to continue or 'n' to exit: ";

            while (choice.Contains("y"))
            {
                Console.Write("Cost of meal: ");
                double mealCost = Convert.ToDouble(Console.ReadLine());

                double optionOne = (mealCost * .15);
                Console.WriteLine("15%");
                Console.WriteLine("Tip amount:  " + "$"+ Math.Round(optionOne, 2));
                Console.WriteLine("Total:       " + "$" + Math.Round(optionOne + mealCost , 2));




                Console.WriteLine();
                Console.Write(Continue);
                choice = Console.ReadLine();
            
        } }
    }
}