namespace WomemFashionManagement.Models
{
  public class Product
  {
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int CategoryId { get; set; }

    public Product()
    {
    }

    public Product(int productId, string productName, decimal price, int quantity, int categoryId)
    {
      ProductId = productId;
      ProductName = productName;
      Price = price;
      Quantity = quantity;
      CategoryId = categoryId;
    }
  }
}