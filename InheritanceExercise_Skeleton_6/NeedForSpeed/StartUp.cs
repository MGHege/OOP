using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportCar = new(100,100);
            sportCar.Drive(1);
           Console.WriteLine(sportCar.Fuel);
        }
    }
}
/*
Cat
Tom 12 Male
Dog
Buddy 132 Male
Beast!
 
 
 
 
 
 
 
 
 **/