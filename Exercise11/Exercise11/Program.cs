using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var bicycle = new Bicycle();
            var vehicleData = new VehicleData();

            car.StartEngine();
            
            vehicleData.PrintVehicle(car);
            vehicleData.PrintVehicle(bicycle);

            Console.ReadLine();
        }
    }
}
