using System.Collections.Generic;

namespace Exercise14
{
    public class TableRow
    {
        private List<TableCell> cells;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cell">The first cell of the row</param>
        public TableRow(TableCell cell)
        {
            cells = new List<TableCell> { cell };
        }

        /// <summary>
        /// A string representation of the HTML table row
        /// </summary>
        /// <returns>The HTML row with cell(s), wrapped in a tr-tag</returns>
        public override string ToString()
        {
            return string.Format("<tr>{0}</tr>", GetCellData());
        }

        /// <summary>
        /// Add a cell to the row
        /// </summary>
        /// <param name="cell">The cell to add</param>
        public void AddCell(TableCell cell)
        {
            cells.Add(cell);
        }

        /// <summary>
        /// Get the number of cells in this row
        /// </summary>
        public int Count 
        {
            get { return cells.Count; }
        }

        /// <summary>
        /// This is a private helper method. Instead of calling ToString on the cell(s) directly,
        /// we can do this in its own method and call it from TableRow's ToString
        /// </summary>
        /// <returns>Cell data as a string</returns>
        private string GetCellData()
        {
            var allCells = string.Empty;

            foreach (var cell in cells)
            {
                allCells += cell.ToString();
            }

            return allCells;
        }
    }
}