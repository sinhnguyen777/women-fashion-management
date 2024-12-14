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
      CustomerView customerView = new CustomerView();

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
        Console.WriteLine("6. Tìm kiếm đơn hàng có giá trị lớn hơn 100 và trạng thái đã hoàn thành");
        Console.WriteLine("7. Tìm kiếm sản phẩm được bán nhiều nhất");
        Console.WriteLine("8. Tìm kiếm khách hàng đã mua hàng nhiều nhất");
        Console.WriteLine("9. Thống kê doanh thu theo tháng trong năm hiện tại");
        Console.WriteLine("10. Thống kê doanh thu trong cả năm");
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
              orderView.orderHightValue();
              break;
            case 7:
              Console.Clear();
              productView.GetProductMostPurchased();
              break;
            case 8:
              Console.Clear();
              customerView.GetCustomerMostPurchased();
              break;
            case 9:
              Console.Clear();
              orderView.revenuesByMonth();
              break;
            case 10:
              Console.Clear();
              orderView.revenuesByYear();
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