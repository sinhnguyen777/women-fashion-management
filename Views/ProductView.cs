using services.Implementations;
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

    // public void DisplayMenu()
    // {
    //   bool isRunning = true;
    //   while (isRunning)
    //   {
    //     Console.Clear();
    //     Console.WriteLine("═══════════════════════ Menu ════════════════════════");
    //     Console.WriteLine("1. Lấy danh sách tất cả sản phẩm");
    //     Console.WriteLine("2. Lấy sản phẩm có giá trị cao nhất theo danh mục");
    //     Console.WriteLine("3. Lấy tên nhân viên theo mã nhân viên");
    //     Console.WriteLine("0. Thoát");
    //     Console.Write("Chọn một tùy chọn (1-3): ");
    //     int choice = int.Parse(Console.ReadLine());
    //     switch (choice)
    //     {
    //       case 1:
    //         DisplayAllProducts();
    //         break;
    //       case 2:
    //         DisplayProductMaxPriceByCategory();
    //         break;
    //       case 0:
    //         isRunning = false;
    //         break;
    //       default:
    //         Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
    //         Console.ReadKey();
    //         break;
    //     }
    //   }
    // }

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
  }
}