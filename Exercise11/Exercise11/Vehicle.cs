namespace Exercise11
{
    public abstract class Vehicle
    {
        private string type;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="vehicleType">Type of vehicle</param>
        public Vehicle(string vehicleType)
        {
            type = vehicleType;
        }

        public virtual string DescribeVehicle()
        {
            return "This is a " + type;
        }
    }
}