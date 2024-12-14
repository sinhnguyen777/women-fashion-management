using WomemFashionManagement.Dto;
using WomemFashionManagement.Repositories;

namespace WomemFashionManagement.Services
{
  public class CustomerService
  {
    private readonly CustomerRepository _customerRepository;
    private readonly OrderService _orderService;

    public CustomerService()
    {
      _customerRepository = new CustomerRepository();
      _orderService = new OrderService();
    }

    // lấy tất cả khách hàng
    public List<CustomerDto> GetAllCustomers()
    {
      try
      {
        var customers = _customerRepository.GetAllCustomers();
        var result = from c in customers
                     select new CustomerDto(c.CustomerId, c.FullName, c.Email, c.Phone, c.Address);
        return result.ToList();
      }
      catch (System.Exception)
      {
        throw new System.Exception("Lỗi khi lấy tất cả khách hàng");
      }
    }

    // lấy khách hàng đã mua hàng nhiều nhất
    public CustomerMostPurchasedDto GetCustomerMostPurchased()
    {
      try
      {
        var customers = this.GetAllCustomers();
        var orders = _orderService.GetAllOrders();
        var result = from c in customers
                     join o in orders on c.CustomerId equals o.CustomerId
                     group c by new { c.CustomerId, c.FullName } into g
                     select new CustomerMostPurchasedDto
                     {
                       CustomerId = g.Key.CustomerId,
                       FullName = g.Key.FullName,
                       TotalOrders = g.Count()
                     };
        return result.OrderByDescending(x => x.TotalOrders).FirstOrDefault();
      }
      catch (System.Exception)
      {
        throw new System.Exception("Lỗi khi lấy khách hàng đã mua hàng nhiều nhất");
      }
    }
  }
}
