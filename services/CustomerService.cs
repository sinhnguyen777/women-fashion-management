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
  }
}
