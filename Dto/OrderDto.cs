namespace WomemFashionManagement.Dto
{
  public class OrderDto
  {
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string? Address { get; set; }
    public string? Status { get; set; }

    public OrderDto()
    {
    }

    public OrderDto(
      int orderId,
      int customerId,
      DateTime orderDate,
      string address,
      string status
    )
    {
      OrderId = orderId;
      CustomerId = customerId;
      OrderDate = orderDate;
      Address = address;
      Status = status;
    }
  }

  public class OrderDetailDto
  {
    public int OrderId { get; set; }
    public string? CustomerName { get; set; }
    public string? ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime OrderDate { get; set; }
    public string? Address { get; set; }
    public decimal Total { get; set; }
    public string? Status { get; set; }

    public OrderDetailDto()
    {
    }

    public OrderDetailDto(
      int orderId,
      string customerName,
      string productName,
      int quantity,
      decimal price,
      DateTime orderDate,
      string address,
      decimal total,
      string status
    )
    {
      OrderId = orderId;
      CustomerName = customerName;
      ProductName = productName;
      Quantity = quantity;
      Price = price;
      OrderDate = orderDate;
      Address = address;
      Total = total;
      Status = status;
    }
  }

  // dto thống kê doanh thu các tháng trong năm hiện tại
  public class RevenueMonthDto
  {
    public int Month { get; set; }
    public decimal Total { get; set; }
    public int QuantityProduct { get; set; }

    public RevenueMonthDto()
    {
    }

    public RevenueMonthDto(int month, decimal total, int quantityProduct)
    {
      Month = month;
      Total = total;
      QuantityProduct = quantityProduct;
    }
  }

  // dto thống kê doanh thu trong năm
  public class RevenueDto
  {
    public int Year { get; set; }
    public decimal Total { get; set; }
    public int QuantityProduct { get; set; }

    public RevenueDto()
    {
    }

    public RevenueDto(int year, decimal total, int quantityProduct)
    {
      Year = year;
      Total = total;
      QuantityProduct = quantityProduct;
    }
  }
}
