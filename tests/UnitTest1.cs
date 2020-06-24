using System;
using Interface;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };
            
            Action act = () => orderProcessor.Process(order);
            var exception = Assert.Throws<ArgumentException>(act);
            
            Assert.Equal("expected error message here", exception.Message);
        }
    }
}