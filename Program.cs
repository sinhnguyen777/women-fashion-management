using System;
using WomemFashionManagement.Views;

namespace WomemFashionManagement
{
  class Program
  {
    static void Main(string[] args)
    {
      ProductView productView = new ProductView();
      OrderView orderView = new OrderView();
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.InputEncoding = System.Text.Encoding.UTF8;
      while (true)
      {
        Console.Clear();
        Console.WriteLine("═══════════════════════ Menu ════════════════════════");
        Console.WriteLine("1. Lấy danh sách tất cả sản phẩm");
        Console.WriteLine("2. Lấy sản phẩm theo danh mục");
        Console.WriteLine("3. Lấy sản phẩm có giá trị cao nhất theo danh mục");
        Console.WriteLine("4. Lấy danh sách tất cả đơn hàng");
        Console.WriteLine("5. Lấy chi tiết đơn hàng theo mã đơn hàng");
        Console.WriteLine("6. Thống kê doang thu theo năm");
        Console.WriteLine("7. Lấy danh sách hóa đơn theo khách hàng");
        Console.WriteLine("8. Lấy danh sách chi tiết hóa đơn của một hóa đơn cụ thể");
        Console.WriteLine("8. Lấy thông tin áo theo mã áo");
        Console.WriteLine("9. Lấy danh sách hóa đơn theo ngày lập");
        Console.WriteLine("10. Lấy danh sách áo có mô tả chứa từ khóa");
        Console.WriteLine("11. Thoát");
        Console.Write("Chọn một tùy chọn (1-11): ");

        int choice;

        if (int.TryParse(Console.ReadLine(), out choice))
        {
          switch (choice)
          {
            case 1:
              Console.Clear();
              productView.DisplayAllProducts();
              break;
            case 2:
              Console.Clear();
              productView.DisplayProductsByCategory();
              break;
            case 3:
              Console.Clear();
              productView.DisplayProductMaxPriceByCategory();
              break;
            case 4:
              Console.Clear();
              orderView.DisplayAllOrders();
              break;
            case 5:
              Console.Clear();
              orderView.DisplayAllOrderDetails();
              break;
            case 6:
              Console.Clear();
              orderView.revenuesByYear();
              break;
            case 7:
              Console.Clear();
              Console.WriteLine("");
              break;
            case 8:
              Console.Clear();
              Console.WriteLine("");
              break;
            case 9:
              Console.Clear();
              Console.WriteLine("");
              break;
            case 10:
              Console.Clear();
              Console.WriteLine("");
              break;
            case 11:
              Console.Clear();
              Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
              return;
            default:
              Console.Clear();
              Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại!");
              break;
          }
        }
        else
        {
          Console.Clear();
          Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại!");
        }

        Console.Write("Nhấn phím bất kỳ để tiếp tục...");
        Console.ReadKey();
        Console.Clear();
      }
    }
  }
}