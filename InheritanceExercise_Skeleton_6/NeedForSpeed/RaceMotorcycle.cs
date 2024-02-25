namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }
        public override double FuelConsumption => 8;
    }
}

