namespace Exercise10
{
    public class Bicycle : Vehicle
    {
        private int numberOfWheels;

        public int NumberOfWheels 
        {
            get { return numberOfWheels; }
        }

        public Bicycle()
        {
            // Bicycles should have two wheels - Otherwise, they get tricky
            numberOfWheels = 2;

            InitialiseVehicle("bicycle");
        }
    }
}