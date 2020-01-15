namespace pieshop.Models
{
	public interface IOrderRepository
	{
		void CreateOrder(Order order);
	}
}