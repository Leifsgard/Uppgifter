using System;

namespace Extra___4
{
    public class GearBox
    {
        private int gear = 1;



        public void MoveGear(int NewGear)
        {
            //NewGear är mellan 1..5)
            int gearDiff = NewGear - gear;

            switch (gearDiff)
            {
                case 1:
                    gear = NewGear;
                    Console.WriteLine("New gear UP " + NewGear);
                    break; 
                case -1:
                    gear = NewGear;
                    Console.WriteLine("New gear DOWN " + NewGear);
                    break;
                case 0:
                    Console.WriteLine("No gear change");
                    break;
                default:
                    Console.WriteLine(
                        "Can't move from gear {0} to {1}", gear, NewGear);
                    break;
            }
        }

        public void MoveGearAlt1(int NewGear)
        {
            if (NewGear < 1 || NewGear > 5)
            {
                Console.WriteLine("Internal error");
                return;
            }


            //NewGear är mellan 1..5)
            int gearDiff = NewGear - gear;

            if (gearDiff == -1 || gearDiff == 0 || gearDiff == 1)
            {
                gear = NewGear;
                Console.WriteLine("New gear " + NewGear);
            }
            else
            {
                Console.WriteLine(
                    "Can't move from gear {0} to {1}", gear, NewGear);
            }
        }
    }
}