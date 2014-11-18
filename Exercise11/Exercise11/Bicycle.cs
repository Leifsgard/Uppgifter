namespace Exercise11
{
    public class Bicycle : Vehicle
    {
        private int numberOfWheels;

        public int NumberOfWheels 
        {
            get { return numberOfWheels; }
        }

        public Bicycle() : base("bicycle")
        {
            // Bicycles should have two wheels - Otherwise, they get tricky
            numberOfWheels = 2;
        }

        public override string DescribeVehicle()
        {
            return string.Format("{0}. It has {1} wheels", base.DescribeVehicle(), numberOfWheels);
        }
    }
}