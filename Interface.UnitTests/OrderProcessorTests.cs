using System;
using Xunit;

namespace Interface.UnitTests
{
    public class OrderProcessorTests
    {
        private readonly OrderProcessor _orderProcessor;
        
        public OrderProcessorTests()
        {
            _orderProcessor = new OrderProcessor(new ShippingCalculator());
        }
        
        [Fact]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var order = new Order()
            {
                TotalPrice = 40,
                Shipment = new Shipment()
            };
            
            var exception = Assert.Throws<InvalidOperationException>(() => _orderProcessor.Process(order));
            
            Assert.Equal("This is already processed.", exception.Message);
            Assert.True(order.IsShipped);
        }
        
        [Fact]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var order = new Order();
            order.TotalPrice = 40;
            _orderProcessor.Process(order);
            
            Assert.True(order.IsShipped);
            Assert.Equal(0, order.Shipment.Cost);
            Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }
    }
}