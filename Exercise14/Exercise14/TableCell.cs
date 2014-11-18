namespace Exercise14
{
    public class TableCell
    {
        /// <summary>
        /// Get or set the content of the cell
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="content">The cell content</param>
        public TableCell(string content="")
        {
            Content = content;
        }

        /// <summary>
        /// A string representation of the HTML table cell
        /// </summary>
        /// <returns>The content, wrapped in a td-tag</returns>
        public override string ToString()
        {
            return string.Format("<td>{0}</td>", Content);
        }
    }
}