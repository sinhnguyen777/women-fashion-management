using WomemFashionManagement.Data;
using WomemFashionManagement.Models;

namespace WomemFashionManagement.Repositories
{
  public class CustomerRepository
  {
    private readonly DataInitializer _dataInitializer;

    public CustomerRepository()
    {
      _dataInitializer = new DataInitializer();
    }

    public List<Customer> GetAllCustomers()
    {
      return _dataInitializer.Customers;
    }

    public Customer GetCustomerById(int customerId)
    {
      return _dataInitializer.Customers.FirstOrDefault(c => c.CustomerId == customerId);
    }
  }
}
