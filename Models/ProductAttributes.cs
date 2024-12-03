namespace WomemFashionManagement.Models
{
  public class ProductAttributes
  {
    public int ProductId { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }

    public ProductAttributes()
    {
    }

    public ProductAttributes(int productId, string size, string color)
    {
      ProductId = productId;
      Size = size;
      Color = color;
    }
  }
}
