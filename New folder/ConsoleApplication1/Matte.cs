using System;

namespace ConsoleApplication1
{

    public interface IAdd
    {
        int Add(int x, int y);
    }
    public interface ISubtract
    {
        int Subtract(int x, int y);
    }
    public interface IMultiply
    {
        int Multiply(int x, int y);
    }

    public class Matte : IAdd, ISubtract, IMultiply, IDivide
    {
        public int Add(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int Divide(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}