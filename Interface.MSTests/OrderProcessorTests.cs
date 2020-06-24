using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interface.MSTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
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