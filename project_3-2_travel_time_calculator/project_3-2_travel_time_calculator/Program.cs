using System;

namespace project_3_2_travel_time_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            Console.WriteLine();
            string choice = "y";
            string Continue = "Press 'y' to continue or 'n' to exit: ";

            while (choice.Contains("y"))
            {
                double m;
                double mph;
                Console.Write("Enter miles:                 ");
                m = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Miles Per Hour:        ");
                mph = Convert.ToDouble(Console.ReadLine());


                //Begin output
                Console.WriteLine();
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                Console.WriteLine();
                double travelTimeHours = m / mph;
                double travelTimeMin = (m / mph % 1)*60;
                Math.Round(travelTimeHours);
                Math.Round(travelTimeMin);
                int hour = (int) travelTimeHours;
                int min = (int)travelTimeMin;
                Console.WriteLine("Hours:     " + hour);
                Console.WriteLine("Minutes:   " + min);
                Console.WriteLine();
                Console.Write(Continue);
                choice = Console.ReadLine();





            }
        }
    }
}
