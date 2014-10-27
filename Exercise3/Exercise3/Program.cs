using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the product's name
            Console.Write("Enter the product name: ");
            string name = Console.ReadLine();

            // Read the price per item
            Console.Write("Enter the price per item: ");
            int price = int.Parse(Console.ReadLine());

            // Read the quantity bought
            Console.Write("Enter the quantity bought: ");
            int quantity = int.Parse(Console.ReadLine());

            // Read whether the item is or is not a food item
            Console.Write("Food item? (y/n): ");
            string foodItem = Console.ReadLine();

            // Calculate the tax. Set it to 10 if fooditem is y, otherwise 25.
            int tax;
            if (foodItem == "y")
            {
                tax = 10;
            }
            else
            {
                tax = 25;
            }

            // Calculate the price before tax
            int totalPreTax = price * quantity;
            
            // Calculate the tax
            int taxPaid = totalPreTax * tax / 100;
            
            // Calculate the total price including tax
            int totalWithTax = totalPreTax + taxPaid;

            // Output the results
            Console.WriteLine("--- RECEIPT ---");
            Console.WriteLine(" Product: " + name);
            Console.WriteLine(" Price per item: " + price);
            Console.WriteLine(" Quantity bought: " + quantity);
            Console.WriteLine();
            Console.WriteLine(" Total to pay, excluding tax: " + totalPreTax);
            Console.WriteLine(" Total to pay, including tax: " + totalWithTax);
            Console.WriteLine(" Of which is tax: " + taxPaid);
            Console.WriteLine("---------------");
        }
    }
}
