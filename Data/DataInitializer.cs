using WomemFashionManagement.Models;

namespace WomemFashionManagement.Data
{
  internal class DataInitializer
  {
    public List<Category> Categories { get; set; }
    public List<Product> Products { get; set; }
    public List<ProductAttributes> ProductAttributes { get; set; }
    public List<Order> Orders { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
    public List<Customer> Customers { get; set; }

    public DataInitializer()
    {
      Categories = new List<Category>
      {
        new Category { CategoryId = 1, CategoryName = "Áo thun" },
        new Category { CategoryId = 2, CategoryName = "Áo sơ mi" },
        new Category { CategoryId = 3, CategoryName = "Áo khoác" },
        new Category { CategoryId = 4, CategoryName = "Áo len" },
        new Category { CategoryId = 5, CategoryName = "Áo croptop" }
      };

      Customers = new List<Customer>
      {
        new Customer { CustomerId = 1, FullName = "Nguyễn Thành Anh", Email = "anh@gmail.com",  Phone = 0966111000, Address = "Hà Nội" },
        new Customer { CustomerId = 2, FullName = "Nguyễn Tấn Bình", Email = "binh@gmail.com", Phone = 0966222000, Address = "Hồ Chí Minh" },
        new Customer { CustomerId = 3, FullName = "Nguyễn Văn Chí", Email = "chi@gmail.com", Phone = 0966333000, Address = "Đà Nẵng" },
        new Customer { CustomerId = 4, FullName = "Lê Hoàn Dũng", Email = "dung@gmail.com", Phone = 0966444000, Address = "Cần Thơ" },
        new Customer { CustomerId = 5, FullName = "Nguyễn Thị Yến Nhi", Email = "yennhi@gmail.com", Phone = 0966555000, Address = "Hải Phòng" }
      };

      Orders = new List<Order>
      {
        new Order { OrderId = 1, OrderDate = new DateTime(2024, 01, 11), CustomerId = 1, Status = "Pending" },
        new Order { OrderId = 2, OrderDate = new DateTime(2024, 02, 02), CustomerId = 2, Status = "In Progress" },
        new Order { OrderId = 3, OrderDate = new DateTime(2024, 03, 03), CustomerId = 3, Status = "Completed" },
        new Order { OrderId = 4, OrderDate = new DateTime(2024, 01, 04), CustomerId = 4, Status = "In Progress" },
        new Order { OrderId = 5, OrderDate = new DateTime(2024, 04, 05), CustomerId = 1, Status = "Completed" },
        new Order { OrderId = 6, OrderDate = new DateTime(2024, 05, 06), CustomerId = 1, Status = "Pending" },
        new Order { OrderId = 7, OrderDate = new DateTime(2024, 06, 07), CustomerId = 2, Status = "In Progress" },
        new Order { OrderId = 8, OrderDate = new DateTime(2024, 07, 08), CustomerId = 3, Status = "Completed" },
        new Order { OrderId = 9, OrderDate = new DateTime(2024, 08, 22), CustomerId = 4, Status = "Pending" },
        new Order { OrderId = 10, OrderDate = new DateTime(2024, 09, 10), CustomerId = 5, Status = "In Progress" },
        new Order { OrderId = 11, OrderDate = new DateTime(2024, 10, 11), CustomerId = 1, Status = "Completed" },
        new Order { OrderId = 12, OrderDate = new DateTime(2024, 11, 12), CustomerId = 2, Status = "Pending" },
        new Order { OrderId = 13, OrderDate = new DateTime(2024, 12, 13), CustomerId = 3, Status = "In Progress" },
      };

      OrderDetails = new List<OrderDetail>
      {
        new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 1 },
        new OrderDetail { OrderId = 2, ProductId = 2, Quantity = 2 },
        new OrderDetail { OrderId = 3, ProductId = 3, Quantity = 3 },
        new OrderDetail { OrderId = 4, ProductId = 1, Quantity = 4 },
        new OrderDetail { OrderId = 5, ProductId = 5, Quantity = 5 },
        new OrderDetail { OrderId = 6, ProductId = 9, Quantity = 2 },
        new OrderDetail { OrderId = 7, ProductId = 1, Quantity = 1 },
        new OrderDetail { OrderId = 8, ProductId = 3, Quantity = 3 },
        new OrderDetail { OrderId = 9, ProductId = 2, Quantity = 2 },
        new OrderDetail { OrderId = 10, ProductId = 5, Quantity = 1 },
        new OrderDetail { OrderId = 11, ProductId = 6, Quantity = 2 },
        new OrderDetail { OrderId = 12, ProductId = 3, Quantity = 3 },
        new OrderDetail { OrderId = 13, ProductId = 11, Quantity = 4 },
      };

      Products = new List<Product>
      {
        new Product { ProductId = 1, ProductName = "Áo khoác thu đông tháng 12", CategoryId = 3, Price = 100000, Quantity = 10 },
        new Product { ProductId = 2, ProductName = "Áo sơ mi tay dài thời trang 2024", CategoryId = 2, Price = 150000, Quantity = 33 },
        new Product { ProductId = 3, ProductName = "Áo thun cổ tròn", CategoryId = 1, Price = 30000, Quantity = 100 },
        new Product { ProductId = 4, ProductName = "Áo khoác nữ mẫu mới 2024", CategoryId = 3, Price = 299000, Quantity = 99 },
        new Product { ProductId = 5, ProductName = "Áo len mùa đông 2024", CategoryId = 4, Price = 270000, Quantity = 10 },
        new Product { ProductId = 6, ProductName = "Áo croptop trắng", CategoryId = 5, Price = 129000, Quantity = 10 },
        new Product { ProductId = 7, ProductName = "Áo khoác thể thao dáng nam", CategoryId = 3, Price = 390000, Quantity = 82 },
        new Product { ProductId = 8, ProductName = "Áo khoác nữ đẹp", CategoryId = 3, Price = 80, Quantity = 1000 },
        new Product { ProductId = 9, ProductName = "Áo thun trắng tay dài 2024", CategoryId = 1, Price = 80000, Quantity = 111 },
        new Product { ProductId = 10, ProductName = "Áo thun thể thao nam", CategoryId = 1, Price = 99000, Quantity = 444 },
        new Product { ProductId = 11, ProductName = "Áo sơ mi học sinh", CategoryId = 2, Price = 244000, Quantity = 10 },
        new Product { ProductId = 12, ProductName = "Áo sơ mi viền đen hoạ tiết caro", CategoryId = 2, Price = 189000, Quantity = 10 },
        new Product { ProductId = 13, ProductName = "Áo len giữ nhiệt", CategoryId = 4, Price = 599000, Quantity = 22 },
      };

      ProductAttributes = new List<ProductAttributes>
      {
        new ProductAttributes { ProductId = 1, Color = "Red", Size = "S" },
        new ProductAttributes { ProductId = 2, Color = "Black", Size = "M" },
        new ProductAttributes { ProductId = 3, Color = "White", Size = "L" },
        new ProductAttributes { ProductId = 4, Color = "Blue", Size = "S" },
        new ProductAttributes { ProductId = 5, Color = "Yellow", Size = "XXL" },
        new ProductAttributes { ProductId = 6, Color = "White", Size = "S" },
        new ProductAttributes { ProductId = 7, Color = "Blue", Size = "L" },
        new ProductAttributes { ProductId = 8, Color = "Black", Size = "L" },
        new ProductAttributes { ProductId = 9, Color = "White", Size = "M" },
        new ProductAttributes { ProductId = 10, Color = "Black", Size = "XXL" },
        new ProductAttributes { ProductId = 11, Color = "White", Size = "M" },
        new ProductAttributes { ProductId = 12, Color = "Green", Size = "L" },
        new ProductAttributes { ProductId = 13, Color = "Red", Size = "S" }
      };
    }
  }
}