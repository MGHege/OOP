using System;
namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }
        public override double FuelConsumption => 3;
    }
}


