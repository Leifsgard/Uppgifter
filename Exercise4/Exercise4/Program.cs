using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect user input
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());

            // Check if the number is positive (stretch task)
            if (number < 0)
            {
                Console.WriteLine("Negative numbers are not allowed!");
            }
            else
            {
                int sum = 0;

                for (var i = 1; i <= number; i++)
                {
                    sum += i;

                    // Stretch task:
                    if (i < number)
                    {
                        Console.Write(i + "+");
                    }
                    else
                    {
                        Console.Write(i + "=");
                    }
                }

                // Write the sum
                Console.Write(sum);
            }

            // Make sure we're not closing before seeing the exciting stuff
            Console.ReadLine();
        }
    }
}
