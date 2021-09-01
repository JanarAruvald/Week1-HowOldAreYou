using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1. programm küsib kasutaja käest kasutaja eesnime
            //Step 2. programm küsib kasutaja käest perekonnanime
            //Step 3. programm tervitab kasutajat kasutades neid andmeid

            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();

            Console.WriteLine($"{FirstName}, What is your last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Hello, {FirstName} {LastName}");

            Console.WriteLine("Ur mum gay!");
           
            Console.Read();
        }
    }
}
