namespace WomemFashionManagement.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public int Phone { get; set; }
    public string? Address { get; set; }

    public Customer()
    {
    }

    public Customer(int customerId, string fullName, string email, int phone, string address)
    {
      CustomerId = customerId;
      FullName = fullName;
      Email = email;
      Phone = phone;
      Address = address;
    }
  }
}