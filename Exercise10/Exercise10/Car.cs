namespace Exercise10
{
    public class Car : Vehicle
    {
        private bool engineIsRunning;

        public Car()
        {
            engineIsRunning = false;

            InitialiseVehicle("car");
        }

        public void StartEngine()
        {
            engineIsRunning = true;
        }

        public void StopEngine()
        {
            engineIsRunning = false;
        }
    }
}