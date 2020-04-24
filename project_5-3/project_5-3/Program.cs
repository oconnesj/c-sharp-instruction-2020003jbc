using System;

namespace project_5_1_dice_roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();
            Random rnd = new Random();

            string rollPrompt = "Roll the dice? (y / n):  ";
            Console.Write(rollPrompt);
            string choice = Console.ReadLine();
            Console.WriteLine();

            while (choice.Contains("y") || choice.Contains("Y"))
            {


                RollDie(rnd);

                Console.WriteLine();
                Console.Write("Roll Again? (y / n): ");
                choice = Console.ReadLine();
                Console.WriteLine();

            }
            Console.WriteLine("Bye");
        }

        private static void RollDie(Random rnd)
        {
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            Console.WriteLine("Die 1:   " + die1);
            Console.WriteLine("Die 2:   " + die2);
            Console.WriteLine("Total:   " + (die1 + die2));
            if (die1 == 1 && die2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if (die1 == 6 && die2 == 6)
            {
                Console.WriteLine("Boxcars!");
            }
        }





    }
}
