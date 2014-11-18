using System;
using System.Linq;
using System.Text;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first row, with three cells
            var row = new TableRow(new TableCell("First cell"));
            row.AddCell(new TableCell("Another cell"));
            row.AddCell(new TableCell("A third cell"));

            var table = new Table(row);

            // Create a second row, but with one cell
            row = new TableRow(new TableCell("Second row, first cell"));
            table.AddRow(row);

            Console.WriteLine(table);
        }
    }
}
