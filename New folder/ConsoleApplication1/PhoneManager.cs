using System.Collections.Generic;

namespace ConsoleApplication1
{
    public interface IPHoneManager
    {
        List<int> GetAllNumbersForCustomer(int customerId);
        void CreateNewNumber(int customerId, string newNumber);
        void Init();
    }


    public abstract class PhoneManager
    {
        public abstract List<int> GetAllNumbersForCustomer(int customerId);
        public abstract void CreateNewNumber(int customerId, string newNumber);
        public abstract void Init();
    }
}