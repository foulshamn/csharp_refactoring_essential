using Moq;

namespace LegacyCode.Test
{
    public class Tests
    {
        private ShippingCalculator _shippingCalculator;
        private Mock<IOrderRequestHandler> _mockOrderRequestHandler;

        [SetUp]
        public void Setup()
        {
            _mockOrderRequestHandler = new Mock<IOrderRequestHandler>();
            _shippingCalculator = new ShippingCalculator(_mockOrderRequestHandler.Object);
        }

        [Test]
        public void ShippingCalculatorTest()
        {
            _mockOrderRequestHandler.Setup(morh => morh.GetOrder(1001)).Returns(new Order(){DistanceKm = 120, ShippingType = "STANDARD", WeightKg = 5});
            Assert.That(_shippingCalculator.CalculateShipping(1001), Is.EqualTo(2.5));
        }
    }
}
