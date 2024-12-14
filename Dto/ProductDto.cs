namespace WomemFashionManagement.Dto
{
  public class ProductDto
  {
    public int? ProductId { get; set; }
    public string? ProductName { get; set; }
    public decimal? Price { get; set; }
    public int? Quantity { get; set; }
    public int? CategoryId { get; set; }
    public string? Size { get; set; }
    public string? Color { get; set; }

    public ProductDto()
    {
    }

    public ProductDto(int productId, string? productName, decimal price, int quantity, int categoryId, string? size, string? color)
    {
      ProductId = productId;
      ProductName = productName;
      Price = price;
      Quantity = quantity;
      CategoryId = categoryId;
      Size = size;
      Color = color;
    }
  }
}