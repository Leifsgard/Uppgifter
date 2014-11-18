using System;

namespace ConsoleApplication1
{
    public interface IOrder
    {
        Decimal TotalSum { get; }
        Decimal Tax { get; }

        void ClearOrder();

        void AddItem(string productName, int quantity, decimal price);
    }
}