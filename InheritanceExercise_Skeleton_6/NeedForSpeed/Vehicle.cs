using System;
using System.Reflection.Metadata;

namespace NeedForSpeed
{
	public class Vehicle
	{
        public const double DefaultFuelConsumption = 1.25;
        public Vehicle(double fuel, int horsePower)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel{ get; set; }
		public int HorsePower { get; set; }
        public virtual void Drive(double kilometers)
        {
            if (this.Fuel - (kilometers * this.FuelConsumption)>=0)
            {
                this.Fuel -= kilometers * this.FuelConsumption;
            }
            

        }
	}
}

