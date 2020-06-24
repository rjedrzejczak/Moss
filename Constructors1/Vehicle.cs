using System;

namespace ConsoleApp1
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is initialazing");

        }
    }
}