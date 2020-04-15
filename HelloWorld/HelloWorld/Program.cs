using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 6;
            int b = 12;
            int sum = (a + b);
            Console.WriteLine("The sum of a and be is: " + sum);
            string test = "The product of a and b is: " + (a * b);
            Console.WriteLine(test);
        }
    }
}
