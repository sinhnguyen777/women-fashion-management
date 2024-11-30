using services.Implementations;
using WomemFashionManagement.Models;
using WomemFashionManagement.Utils;

namespace WomemFashionManagement.Views
{
  public class ProductView
  {
    private readonly ProductService _productService;

    public ProductView()
    {
      _productService = new ProductService();
    }

    public void DisplayProductsByCategory()
    {
      Console.WriteLine("Nhập ID danh mục sản phẩm: ");
      int categoryId = int.Parse(Console.ReadLine());
      List<Product> products = _productService.GetProductsByCategory(categoryId);
      TableRender.CreateTable(products);
    }

    public void DisplayProductsByPriceRange()
    {
      Console.WriteLine("Nhập giá trị tối thiểu: ");
      decimal minPrice = decimal.Parse(Console.ReadLine());
    }
  }
}