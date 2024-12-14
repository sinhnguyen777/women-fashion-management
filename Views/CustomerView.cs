using WomemFashionManagement.Dto;
using WomemFashionManagement.Services;
using WomemFashionManagement.Utils;

namespace WomemFashionManagement.Views
{
  public class CustomerView
  {
    private readonly CustomerService _customerService;
    public CustomerView()
    {
      _customerService = new CustomerService();
    }

    public void GetCustomerMostPurchased()
    {
      Console.WriteLine("Khách hàng mua nhiều nhất: \n");
      var customer = _customerService.GetCustomerMostPurchased();
      TableRender.CreateTable(new List<CustomerMostPurchasedDto> { customer });
    }
  }
}