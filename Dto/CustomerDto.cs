namespace WomemFashionManagement.Dto
{
  public class CustomerDto
  {
    public int CustomerId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }

    public CustomerDto()
    {
    }

    public CustomerDto(int customerId, string fullName, string email, int phone, string address)
    {
      CustomerId = customerId;
      FullName = fullName;
      Email = email;
      Phone = phone;
      Address = address;
    }
  }

  // dto khách hàng mua hàng nhiều nhất
  public class CustomerMostPurchasedDto
  {
    public int CustomerId { get; set; }
    public string FullName { get; set; }
    public int TotalOrders { get; set; }

    public CustomerMostPurchasedDto()
    {
    }

    public CustomerMostPurchasedDto(int customerId, string fullName, int totalOrder)
    {
      CustomerId = customerId;
      FullName = fullName;
      TotalOrders = totalOrder;
    }
  }
}
