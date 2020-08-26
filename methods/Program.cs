using System;

namespace methods
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        { 
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            // ------- Exercise 2 ------- //
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

            // ---End--Exercise 2 ------- //

            // ------- Exercise 1 ------- //
            // Name: Rob
            // Favorite color: Green
            // Favorite animal: Harpy
            // Favorite band: Brian Eno

            Console.WriteLine("Hello, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?"); 
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("$Thanks {userName}! Here is your profile");
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");
        }
    }
}
