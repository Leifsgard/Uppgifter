using System;
using System.Collections.Generic;

namespace Exercise14
{
    public class Table
    {
        private List<TableRow> rows;

        /// <summary>
        /// Constructor #1
        /// </summary>
        public Table()
        {
            // Just create the list, without adding anything
            rows = new List<TableRow>();
        }

        /// <summary>
        /// Constructor #2
        /// </summary>
        /// <param name="row">The first row in the table</param>
        public Table(TableRow row)
        {
            // Create the list and add the row to it
            rows = new List<TableRow> {row};
        }

        /// <summary>
        /// Get the largest amount of cells in any row
        /// </summary>
        private int MaxRowCount
        {
            get
            {
                int max = 0;

                foreach (var tableRow in rows)
                {
                    if (tableRow.Count > max)
                        max = tableRow.Count;
                }

                return max;
            }
        }

        /// <summary>
        /// Pad a row by adding empty cells
        /// </summary>
        /// <param name="row">The row to pad</param>
        /// <param name="size">The number of cells that the finished row should have</param>
        private void PadRow(TableRow row, int size)
        {
            while (row.Count < size)
            {
                // Add an empty cell
                row.AddCell(new TableCell());
            }
        }

        /// <summary>
        /// Pad the entire collection of rows to a certain size
        /// </summary>
        private void PadAllRows(int size)
        {
            foreach (var tableRow in rows)
            {
                // Add empty cells to all rows
                PadRow(tableRow, size);
            }
        }

        /// <summary>
        /// Add a row to the table
        /// </summary>
        /// <param name="row">The row to add</param>
        public void AddRow(TableRow row)
        {
            var maxCount = MaxRowCount;

            // Everytime we add a row, we have to check whether this one contains the most cells or not
            if (row.Count > maxCount)
            {
                // This is the row with the most cells. Pad every other row by adding empty cells
                PadAllRows(row.Count);
            }
            else
            {
                // This is NOT the row with the most cells. Pad this row to the correct size
                PadRow(row, maxCount);
            }

            rows.Add(row);
        }

        /// <summary>
        /// A string representation of the HTML table
        /// </summary>
        /// <returns>The HTML table with its rows, wrapped in a table-tag</returns>
        public override string ToString()
        {
            return string.Format("<table border='1'>{0}</table>", GetRowData());
        }

        /// <summary>
        /// This is a private helper method to return all the rows as a single string
        /// </summary>
        /// <returns>A string, representing every row in the table</returns>
        private string GetRowData()
        {
            // Initialize an empty string (string.Empty is basically the same as "")
            string allRows = string.Empty;

            foreach (var tableRow in rows)
            {
                allRows += tableRow.ToString();
            }

            return allRows;
        }
    }
}