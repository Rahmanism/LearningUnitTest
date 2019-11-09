using LearningUnitTest.Mocking;
using Moq;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        private OrderService _service;
        private Mock<IStorage> _storage;

        [SetUp]
        public void SetUp()
        {
            _storage = new Mock<IStorage>();
            _service = new OrderService(_storage.Object);
        }

        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var order = new Order();
            _service.PlaceOrder(order);
            
            // Assert
            _storage.Verify(s => s.Store(order));
        }
    }
}