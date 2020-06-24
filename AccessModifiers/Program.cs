using System;
using Amazon;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
            // var rateCalculator = new RateCalculator();
            // rateCalculator.Calculate(customer);

            //Amazon.Console.WriteLine("Hello World!");
        }
    }
}