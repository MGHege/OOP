namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }
        public override double FuelConsumption
        {
            get
            {
                return 10;
            }
        }
    }
}

