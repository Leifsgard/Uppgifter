namespace Extra___6
{
    public class Car
    {
        private Engine engine = new Engine();
        private GearBox gearbox = new GearBox();
        private string carModel = "";


        public void StartEngine()
        {
            engine.StartEngine();
        }
        public void StopEngine()
        {
            engine.StopEngine();
        }

        public void MoveGear(int NewGear)
        {
            gearbox.MoveGear(NewGear);
        }

        public void StoreCarModel(string newModel)
        {
            carModel = newModel;
        }

        public string GetCarModel()
        {
            return carModel;
        }
    }
}