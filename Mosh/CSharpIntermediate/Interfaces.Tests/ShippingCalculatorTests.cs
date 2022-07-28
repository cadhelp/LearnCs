
//NOTE This was automatically created using Right-Click Create Tests

namespace Interfaces.UnitTests
{
    using Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class ShippingCalculatorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod()]
        public void CalculateShipping_TotalPriceIsLessThanThirty_CalculateShipping()
        {
            Order order = new Order{TotalPrice = 20f};
            ShippingCalculator shippingCalculator = new ShippingCalculator();
            order.Shipment = new Shipment
                                 {
                                     Cost = shippingCalculator.CalculateShipping(order)
                                 };

            Assert.AreEqual(2,order.Shipment.Cost);
        }

        [TestMethod()]
        public void CalculateShipping_TotalPriceIsThirty_FreeShipping()
        {
            Order order = new Order{TotalPrice = 30f};
            ShippingCalculator shippingCalculator = new ShippingCalculator();
            order.Shipment = new Shipment
                                 {
                                     Cost = shippingCalculator.CalculateShipping(order)
                                 };

            Assert.AreEqual(0,order.Shipment.Cost);
        }

        [TestMethod()]
        public void CalculateShipping_TotalPriceIsGreaterThanThirty_FreeShipping()
        {
            Order order = new Order{TotalPrice = 31f};
            ShippingCalculator shippingCalculator = new ShippingCalculator();
            order.Shipment = new Shipment
                                 {
                                     Cost = shippingCalculator.CalculateShipping(order)
                                 };

            Assert.AreEqual(0,order.Shipment.Cost);
        }
    }
}