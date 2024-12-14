namespace WomemFashionManagement.Models
{
  public class OrderDetail
  {
    public int OrderDetailId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }

    public OrderDetail()
    {
    }

    public OrderDetail(int orderDetailId, int orderId, int productId, int quantity, decimal price, decimal total)
    {
      OrderDetailId = orderDetailId;
      OrderId = orderId;
      ProductId = productId;
      Quantity = quantity;
      Price = price;
      Total = total;
    }
  }
}