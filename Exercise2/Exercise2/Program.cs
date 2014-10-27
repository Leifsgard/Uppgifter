using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect a bunch of input from the user:

            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            Console.Write("Where do you work? ");
            var work = Console.ReadLine();

            Console.Write("How old are you? ");
            var age = Console.ReadLine();

            Console.Write("What is your title? ");
            var title = Console.ReadLine();

            // Print an empty line, for the sake of aesthetics:
            Console.WriteLine();

            // Calculate the birthyear of the user
            var birthYear = DateTime.Now.Year - int.Parse(age);

            // Write everything, using string formatting
            Console.WriteLine("Hello, {0}.\n" +
                              "You are {1} years old, which means that you were born in {2}.\n" +
                              "You work at {3}, where \"{4}\" is your title.",
                name, age, birthYear, work, title);

            // Make sure that the program don't end before we have a chanse to see any output
            Console.ReadLine();
        }
    }
}
