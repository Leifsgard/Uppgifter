using System;

namespace Extra___5
{
    internal class ParkingGargage
    {
        private Car[] garage = new Car[10];

        public void ParkCar(int slot, Car car)
        {
            garage[slot] = car;
        }

        public Car GetCar(int slot)
        {
            var c = garage[slot];
            garage[slot] = null;
            return c;
        }

        public void ListAllCars()
        {
            for (int i = 0; i < garage.Length; i++)
            {
                var c = garage[i];
                if (c != null)
                {
                    var model = c.GetCarModel();
                    Console.WriteLine("Slot {0} - {1}",
                        i, model);
                }
                else
                {
                    Console.WriteLine("Slot {0} - ledig", i);
                }
            }
            

        }
    }
}