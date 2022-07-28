using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// To create the tests we name the test file after the class and add Tests to the end
// Then we look at each method and the exit points and write a test for each exit
// Below we are testing the OrderProcessor.Process method to ensure it
// will throw an error if the order has already been processed AND
// when we create a shipment, the properties are set properly
namespace Interfaces.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        // When you expect and error to be thrown, you use the attribute above
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());

            Order order = new Order{Shipment = new Shipment()};

            orderProcessor.Process(order);
        }


        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            Order order = new Order( );

            orderProcessor.Process(order);

            // When you test for properties and other conditions you need to Assert certain things happen.
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1),order.Shipment.ShippingDate);
        }

        // We created this fake shipping Calculator based on its interface
        // we are not testing the CalculateShipping and just need basic values
        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
