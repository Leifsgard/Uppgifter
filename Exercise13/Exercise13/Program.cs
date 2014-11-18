using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their details
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("What year were you born? (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            
            Console.Write("What month were you born? (mm): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("What day were you born? (dd): ");
            int day = int.Parse(Console.ReadLine());

            // Get right now
            var now = DateTime.Now;

            // Calculate user's 100th birthday
            var oneHundred = new DateTime(year + 100, month, day);


            // Calculate user's next birthday THIS year by using today's year but the user's month and day.
            var nextBirthday = new DateTime(now.Year, month, day);
            

            // Calculate how long until their next birthday.
            var untilNextBirthday = nextBirthday - now;

            // Bool to track if birthday is soon
            bool birthdaySoon;

            // Check if the birthday is within the next 30 days.
            // We should make sure it's positive, too!
            if (untilNextBirthday.Days <= 30 && untilNextBirthday.Days > 0)
            {
                birthdaySoon = true;
            }
            else
            {
                birthdaySoon = false;
            }


            // Output the data
            Console.WriteLine();
            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine();
            if (birthdaySoon)
            {
                Console.WriteLine("Your birthday is soon! It's only {0} days away.", untilNextBirthday.Days);
            }
            else
            {
                Console.WriteLine("Your birthday is still a while away.");
            }
            Console.WriteLine();
            Console.WriteLine("Your 100th birthday will be on a {0}.", oneHundred.DayOfWeek);
        }
    }
}
