using System;

namespace Extra___6
{
    public class Engine
    {
        private bool started = false;
        public void StartEngine()
        {
            if (started == false)
            {
                Console.WriteLine("Engine started");
                started = true;
            }
            else
            {
                Console.WriteLine("Engine is already started");
            }

        }

        public void StopEngine()
        {
            if (started == true)
            {
                Console.WriteLine("Engine stopped");
                started = false;
            }
            else
            {
                Console.WriteLine("Engine is already stopped");
            }
        }
    }
}