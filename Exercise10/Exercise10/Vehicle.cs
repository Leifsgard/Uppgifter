namespace Exercise10
{
    public class Vehicle
    {
        private string type;

        /// <summary>
        /// Initialise the vehicle
        /// </summary>
        /// <param name="vehicleType">Type of vehicle</param>
        public void InitialiseVehicle(string vehicleType)
        {
            type = vehicleType;
        }

        public string DescribeVehicle()
        {
            return "This is a " + type;
        }
    }
}