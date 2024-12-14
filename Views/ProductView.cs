using services.ProductService;
using WomemFashionManagement.Dto;
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

    public void DisplayAllProducts()
    {
      Console.WriteLine("Danh sách tất cả sản phẩm: \n");
      var products = _productService.GetAllProducts();
      TableRender.CreateTable(products);
    }

    public void DisplayProductsByCategory()
    {
      Console.Write("Nhập mã danh mục sản phẩm: \n");
      int categoryId = int.Parse(Console.ReadLine());
      var products = _productService.GetProductsByCategory(categoryId);
      TableRender.CreateTable(products);
    }

    public void DisplayProductMaxPriceByCategory()
    {
      Console.Write("Nhập tên danh mục sản phẩm: \n");
      string? categoryName = Console.ReadLine();
      ProductDto? product = _productService.GetProductMaxPriceByCategory(categoryName);
      if (product == null)
      {
        Console.WriteLine("Không tìm thấy sản phẩm nào trong danh mục này.");
        Console.WriteLine("Vui lòng nhập lại tên danh mục.");
        DisplayProductMaxPriceByCategory();
      }
      else
      {
        Console.WriteLine($"Sản phẩm có giá trị cao nhất trong danh mục {categoryName} là: \n");
        TableRender.CreateTable(new List<ProductDto> { product });
      }
    }

    public void GetProductMostPurchased()
    {
      Console.WriteLine("Sản phẩm được mua nhiều nhất: \n");
      var product = _productService.GetProductMostPurchased();
      TableRender.CreateTable(new List<ProductsMostPurchasedDto> { product });
    }
  }
}