namespace Exercies4_CSharp
{
    internal class Tesla:ICar,IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }
        public Tesla(string model, string color, int batteries)
        { 
            Model = model;
            Color = color;
            Batteries = batteries;
        }
        public string Start()
        {
            return "Engine start\n";
        }
        public string Stop()
        { // TODO: Add Logic here
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla Model {Model} with {Batteries} Batteries\n{Start()}{Stop()}";
        }

    }
}