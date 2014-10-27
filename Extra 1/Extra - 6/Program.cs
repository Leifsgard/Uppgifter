using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra___6
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingGargage PG = new ParkingGargage();

            Car c1 = new Car();
            c1.StoreCarModel("Volvo V70");
            PG.ParkCar(0, c1);

            Car c2 = new Car();
            c2.StoreCarModel("Ford");
            PG.ParkCar(5, c2);

            PG.ListAllCars();



        }
    }
}
