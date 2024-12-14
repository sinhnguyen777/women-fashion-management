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

    public void orderHightValue()
    {
      Console.WriteLine("Danh sách đơn hàng có giá trị lớn hơn 100 và trạng thái đã hoàn thành: \n");
      var orders = _orderService.orderHightValue();
      TableRender.CreateTable(orders);
    }
    public void revenuesByMonth()
    {
      Console.WriteLine("Doanh thu theo tháng: \n");
      var revenues = _orderService.revenuesByMonth();
      TableRender.CreateTable(revenues);
    }

    public void revenuesByYear()
    {
      Console.Write("Doanh thu theo năm: ");
      var revenues = _orderService.revenuesByYear();
      TableRender.CreateTable(revenues);
    }
  }
}
