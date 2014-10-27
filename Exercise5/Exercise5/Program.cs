using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop condition - True while running the program
            bool running = true;

            while (running)
            {
                // Clear the screen and writeout the menu
                Console.Clear();
                Console.WriteLine("Select an operator");
                Console.WriteLine("------------------");
                Console.WriteLine("A. Addition (+)");
                Console.WriteLine("B. Subtraction (-)");
                Console.WriteLine("C. Multiplication (*)");
                Console.WriteLine("D. Division");
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Enter the first number: ");
                var numA = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                var numB = int.Parse(Console.ReadLine());

                // Use this to determine if the calculation succeeded - Assume true to begin with
                bool validMainChoice = true;

                // Declare an integer to use for the result
                int result = 0;

                // Apply a switch and calculate
                switch (choice)
                {
                    case "A": // Addition
                        result = numA + numB;
                        break;

                    case "B": // Subtraction
                        result = numA - numB;
                        break;

                    case "C": // Multiplication
                        result = numA*numB;
                        break;

                    case "D": // Division
                        result = numA/numB;
                        break;

                    default: // The user entered something else - Show an error message
                        validMainChoice = false;
                        Console.WriteLine("{0} is not a valid choice! Try again!", choice);
                        Console.ReadLine();
                        break;
                }


                if (validMainChoice)
                {
                    // If the user made a sane choice in the menu, print the result:
                    Console.WriteLine("Result: {0}", result);

                    // Wait or input
                    Console.ReadLine();
                }


                // Use this to determine if the user answered y or n
                bool validYesNo;

                // This loop will run until the user answers "y" or "n"
                do
                {
                    // Ask the user if he/she wants to do more calculations
                    Console.Write("Do you want to make another calculation? (y/n) ");
                    var goAgain = Console.ReadLine();

                    switch(goAgain)
                    {
                        case "n":
                            running = false;
                            validYesNo = true;
                            break;

                        case "y":
                            validYesNo = true;
                            break;

                        default:
                            validYesNo = false;
                            break;
                    }
                } while (!validYesNo);
            }
        }
    }
}
