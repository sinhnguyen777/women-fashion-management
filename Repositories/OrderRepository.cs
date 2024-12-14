using WomemFashionManagement.Data;
using WomemFashionManagement.Dto;
using WomemFashionManagement.Models;
using WomemFashionManagement.Repositories;

namespace Repositories.OrderRepository
{
  public class OrderRepository : BaseRepository<Order>
  {
    private readonly DataInitializer _dataInitializer;
    public OrderRepository()
    {
      _dataInitializer = new DataInitializer();
    }

    public List<Order> GetAllOrders()
    {
      return _dataInitializer.Orders;
    }

    public List<OrderDetail> GetAllOrderDetails()
    {
      return _dataInitializer.OrderDetails;
    }

    public Order GetOrderById(int orderId)
    {
      return _dataInitializer.Orders.FirstOrDefault(o => o.OrderId == orderId);
    }

    public void AddOrder(Order order)
    {
      _dataInitializer.Orders.Add(order);
    }

    public void UpdateOrder(Order order)
    {
      var existingOrder = GetOrderById(order.OrderId);
      if (existingOrder != null)
      {
        existingOrder = order;
      }
    }

    public void DeleteOrder(int orderId)
    {
      var order = GetOrderById(orderId);
      if (order != null)
      {
        _dataInitializer.Orders.Remove(order);
      }
    }
  }
}
