namespace LearningUnitTest.Mocking
{
    public class OrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage storage)
        {
            _storage = storage;
        }

        public int PlaceOrder(Order order)
        {
            var orderId = _storage.Store(order);
            
            // .....
            
            return orderId;
        }
        
    }

    public interface IStorage
    {
        int Store(object obj);
    }

    public class Order
    {
    }
}