using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProccessor.Process(order);
        }

        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
