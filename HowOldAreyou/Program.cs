using System;

namespace HowOldAreyou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats ur name?");
            //Readline() to read the user input from the console
            string UserName = Console.ReadLine();

            //Console.WriteLine("Hello," + UserName + "!");
            //string interpolation
            Console.WriteLine($"Hello, {UserName}");

            Console.WriteLine("How old are you? Enter digits only:");

            int Age = Int32.Parse(Console.ReadLine());

            int YearOfBirth = 2021 - Age;
            //Console.WriteLine("You were born in " + YearOfBirth);
            Console.WriteLine($"You were born in {YearOfBirth}");


            Console.Read();
        }
    }
}
