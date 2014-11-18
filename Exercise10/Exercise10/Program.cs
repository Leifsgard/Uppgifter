using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleData = new VehicleData();
            var car = new Car();
            var bicycle = new Bicycle();

            vehicleData.PrintVehicle(car);
            vehicleData.PrintVehicle(bicycle);
        }
    }
}
