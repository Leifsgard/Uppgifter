namespace Exercise11
{
    public class Car : Vehicle
    {
        private bool engineIsRunning;

        public Car() : base("car")
        {
            engineIsRunning = false;
        }

        public void StartEngine()
        {
            engineIsRunning = true;
        }

        public void StopEngine()
        {
            engineIsRunning = false;
        }

        public override string DescribeVehicle()
        {
            string running;

            if (engineIsRunning)
                running = "running";
            else
                running = "not running";

            return string.Format("{0}, where the engine is {1}", base.DescribeVehicle(), running);
        }
    }
}