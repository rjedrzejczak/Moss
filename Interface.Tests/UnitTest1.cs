using System;
using NUnit.Framework;

namespace Interface.Tests
{
    public class Tests
    {
        // [SetUp]
        // public void Setup()
        // {
        // }

        [Test]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };
            
            orderProcessor.Process(order);
            
            
        }
    }
}