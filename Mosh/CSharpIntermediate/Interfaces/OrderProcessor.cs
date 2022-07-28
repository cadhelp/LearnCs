using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            //this._shippingCalculator = new ShippingCalculator();// Instead below we are now passing in an IShippingCalculator

            this._shippingCalculator = shippingCalculator;// using the interface we are no longer tightly coupled with the ShippingCalculator.
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            order.Shipment = new Shipment
                                 {
                                     Cost = this._shippingCalculator.CalculateShipping(order), 
                                     ShippingDate = DateTime.Today.AddDays(1)
                                 };
        }
    }
}
