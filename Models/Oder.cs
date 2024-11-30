namespace WomemFashionManagement.Models
{
  public class Order
  {
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    public string? Status { get; set; }

    public Order()
    {
    }

    public Order(int orderId, int customerId, DateTime orderDate, decimal total, string status)
    {
      OrderId = orderId;
      CustomerId = customerId;
      OrderDate = orderDate;
      Total = total;
      Status = status;
    }
  }
}