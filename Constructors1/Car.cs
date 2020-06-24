using System;
using ConsoleApp1;

namespace Consturctors1
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) 
           : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized");
        }
    }
}