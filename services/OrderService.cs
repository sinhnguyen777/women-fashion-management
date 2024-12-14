using Repositories.OrderRepository;
using Repositories.ProductRepository;
using services.ProductService;
using WomemFashionManagement.Dto;
using WomemFashionManagement.Models;
using WomemFashionManagement.Repositories;

namespace WomemFashionManagement.Services
{
  public class OrderService
  {
    private readonly OrderRepository _orderRepository;
    private readonly CustomerRepository _customerRepository;
    private readonly ProductService _productService;

    public OrderService()
    {
      _orderRepository = new OrderRepository();
      _productService = new ProductService();
      _customerRepository = new CustomerRepository();
    }

    // lấy tất cả các đơn hàng
    public List<OrderDto> GetAllOrders()
    {
      try
      {
        var orders = _orderRepository.GetAllOrders();
        var customers = _customerRepository.GetAllCustomers();

        var products = _productService.GetAllProducts();
        var orderDetails = _orderRepository.GetAllOrderDetails();

        var result = from o in orders
                     join c in customers on o.CustomerId equals c.CustomerId
                     join od in orderDetails on o.OrderId equals od.OrderId
                     join p in products on od.ProductId equals p.ProductId
                     select new OrderDto
                     {
                       OrderId = o.OrderId,
                       CustomerId = c.CustomerId,
                       OrderDate = o.OrderDate,
                       Address = c.Address,
                       Status = o.Status
                     };

        return result.ToList();
      }
      catch (System.Exception)
      {
        throw new System.Exception("Lỗi khi lấy tất cả đơn hàng");
      }
    }

    // lấy chi tiết đơn hàng theo mã đơn hàng
    public OrderDetailDto GetAllOrderDetails(int orderId)
    {
      try
      {
        var orders = this.GetAllOrders();
        var customers = _customerRepository.GetAllCustomers();
        var products = _productService.GetAllProducts();
        var orderDetails = _orderRepository.GetAllOrderDetails();

        var result = from od in orderDetails
                     join o in orders on od.OrderId equals o.OrderId
                     join c in customers on o.CustomerId equals c.CustomerId
                     join p in products on od.ProductId equals p.ProductId
                     where od.OrderId == orderId
                     select new OrderDetailDto
                     {
                       OrderId = o.OrderId,
                       CustomerName = c.FullName,
                       ProductName = p.ProductName,
                       Quantity = od.Quantity,
                       Price = od.Price,
                       OrderDate = o.OrderDate,
                       Address = c.Address,
                       Total = od.Total,
                       Status = o.Status
                     };
        return result.FirstOrDefault();
      }
      catch (System.Exception)
      {
        throw new System.Exception("Lỗi khi lấy chi tiết đơn hàng");
      }
    }

    // thống kê doanh thu các tháng trong năm hiện tại
    public List<RevenueMonthDto> revenuesByMonth()
    {
      try
      {
        var currentYear = DateTime.Now.Year;
        var orders = this.GetAllOrders();
        var orderDetails = _orderRepository.GetAllOrderDetails();
        var products = _productService.GetAllProducts();

        var result = from o in orders
                     join od in orderDetails on o.OrderId equals od.OrderId
                     join p in products on od.ProductId equals p.ProductId
                     where o.OrderDate.Year == currentYear
                     group new { od, p } by new { o.OrderDate.Month } into g
                     select new RevenueMonthDto
                     {
                       Month = g.Key.Month,
                       Total = g.Sum(x => (x.od.Quantity * x.p.Price) ?? 0),
                       QuantityProduct = g.Sum(x => x.od.Quantity)
                     };

        var allMonths = Enumerable.Range(1, 12).Select(m => new RevenueMonthDto
        {
          Month = m,
          Total = result.FirstOrDefault(r => r.Month == m)?.Total ?? 0,
          QuantityProduct = result.FirstOrDefault(r => r.Month == m)?.QuantityProduct ?? 0
        }).ToList();

        return allMonths;
      }
      catch (System.Exception)
      {
        throw new System.Exception("Lỗi khi thống kê doanh thu các tháng");
      }
    }

    // thống kê doanh thu trong năm hiện tại
    public List<RevenueDto> revenuesByYear()
    {
      try
      {
        var currentYear = DateTime.Now.Year;
        var orders = this.GetAllOrders();
        var products = _productService.GetAllProducts();
        var orderDetails = _orderRepository.GetAllOrderDetails();

        var result = from o in orders
                     join od in orderDetails on o.OrderId equals od.OrderId
                     join p in products on od.ProductId equals p.ProductId
                     where o.OrderDate.Year == currentYear
                     group new { od, p } by new { o.OrderDate.Year } into g
                     select new RevenueDto
                     {
                       Year = g.Key.Year,
                       Total = g.Sum(x => (x.od.Quantity * x.p.Price) ?? 0),
                       QuantityProduct = g.Sum(x => x.od.Quantity)
                     };

        return result.ToList();
      }
      catch (System.Exception)
      {
        throw new System.Exception("Lỗi khi thống kê doanh thu trong năm");
      }
    }
  }
}
