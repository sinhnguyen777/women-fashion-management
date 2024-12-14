using WomemFashionManagement.Dto;
using WomemFashionManagement.Services;
using WomemFashionManagement.Utils;

namespace WomemFashionManagement.Views
{
  public class OrderView
  {
    private readonly OrderService _orderService;

    public OrderView()
    {
      _orderService = new OrderService();
    }

    public void DisplayAllOrders()
    {
      Console.WriteLine("Danh sách tất cả đơn hàng: \n");
      var orders = _orderService.GetAllOrders();
      TableRender.CreateTable(orders);
    }

    public void DisplayAllOrderDetails()
    {
      Console.WriteLine("Danh sách chi tiết đơn hàng: \n");
      Console.Write("Nhập mã đơn hàng: ");
      int orderId = int.Parse(Console.ReadLine());
      var orderDetails = _orderService.GetAllOrderDetails(orderId);
      TableRender.CreateTable(new List<OrderDetailDto> { orderDetails });
    }

    public void revenuesByYear()
    {
      Console.Write("Nhập năm: ");
      int year = int.Parse(Console.ReadLine());
      var revenues = _orderService.revenuesByYear(year);
      TableRender.CreateTable(revenues);
    }
  }
}
