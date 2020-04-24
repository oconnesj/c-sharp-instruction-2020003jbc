using System;

namespace ch5_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some moethods!");
            Console.WriteLine();

            int nbr = GetInt("Enter a whole number:  ");

            Console.WriteLine("Number entered = " + nbr);

            Console.WriteLine("sum 3 numbers = " + sum(1,2,3));
            Console.WriteLine("sum 2 numbers = " + sum(1,2));


        }

        private static int GetInt(string prompt)
        {
            int nbr;
            bool success = false;
            while (!success) {
                Console.Write(prompt);

                try
                {
                    string nbrStr = Console.ReadLine();
                    // conver that string to an int 
                    nbr = int.Parse(nbrStr);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid # value.");
                    //  Console.WriteLine(e.StackTrace);
                }
                return nbr;

            }

            private static int sum(int n1, int n2, int n3 = 0)
            {
                    int sum = n1 + n2 + n3;
                    return sum;

                }
            }
        }
    }

