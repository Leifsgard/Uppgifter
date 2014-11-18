using System;

namespace ConsoleApplication1
{
    public class Order
    {
        public Decimal TotalSum { get; private set; }

        public Decimal Tax
        {
            get { return TotalSum* 0.2m; }
        }

        public void ClearOrder()
        {
            
        }

        public void AddItem(string productName, int quantity, decimal price)
        {
            
        }
    
    }
}