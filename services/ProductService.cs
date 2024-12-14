using Repositories.CategoriesRepository;
using Repositories.OrderRepository;
using Repositories.ProductRepository;
using WomemFashionManagement.Dto;

namespace services.ProductService
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoriesRepository _categoriesRepository;
        private readonly OrderRepository _orderRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
            _categoriesRepository = new CategoriesRepository();
            _orderRepository = new OrderRepository();
        }

        // lấy tất cả sản phẩm
        public List<ProductDto> GetAllProducts()
        {
            try
            {
                return _productRepository.GetAllProducts();
            }
            catch (System.Exception)
            {
                throw new System.Exception("Lỗi khi lấy tất cả sản phẩm");
            }
        }

        // lấy sản phẩm theo mã danh mục
        public List<ProductDto> GetProductsByCategory(int categoryId)
        {
            try
            {
                var products = _productRepository.GetAllProducts();
                var categories = _categoriesRepository.GetAllCategories();

                var productsByCategory = from p in products
                                         join c in categories on p.CategoryId equals c.CategoryId
                                         where c.CategoryId == categoryId
                                         select p;
                return productsByCategory.ToList();
            }
            catch (System.Exception)
            {
                throw new System.Exception("Lỗi khi lấy sản phẩm theo danh mục");
            }
        }

        // lấy sản phẩm theo tên danh mục
        public List<ProductDto> GetProductsByCategoryName(string categoryName)
        {
            try
            {
                var products = _productRepository.GetAllProducts();
                var categories = _categoriesRepository.GetAllCategories();

                var productsByCategory = from p in products
                                         join c in categories on p.CategoryId equals c.CategoryId
                                         where c.CategoryName == categoryName
                                         select p;
                return productsByCategory.ToList();
            }
            catch (System.Exception)
            {
                throw new System.Exception("Lỗi khi lấy sản phẩm theo danh mục");
            }
        }

        // lấy sản phẩm có giá trị cao nhất theo danh mục
        public ProductDto? GetProductMaxPriceByCategory(string categoryName)
        {
            try
            {
                var products = _productRepository.GetAllProducts();
                var categories = _categoriesRepository.GetAllCategories();

                var productsByCategory = from p in products
                                         join c in categories on p.CategoryId equals c.CategoryId
                                         where c.CategoryName == categoryName
                                         orderby p.Price descending
                                         select p;

                return productsByCategory.FirstOrDefault();
            }
            catch (System.Exception)
            {
                throw new System.Exception("Lỗi khi lấy sản phẩm cao tiền nhất theo danh mục");
            }
        }

        // lấy sản phẩm được mua nhiều nhất
        public ProductsMostPurchasedDto GetProductMostPurchased()
        {
            try
            {
                var products = _productRepository.GetAllProducts();
                var orderDetails = _orderRepository.GetAllOrderDetails();

                var result = from od in orderDetails
                             join p in products on od.ProductId equals p.ProductId
                             group od by new { od.ProductId, p.ProductName } into g
                             select new ProductsMostPurchasedDto
                             {
                                 ProductId = g.Key.ProductId,
                                 ProductName = g.Key.ProductName,
                                 NumberOfPurchases = g.Sum(x => x.Quantity)
                             };

                return result.OrderByDescending(x => x.NumberOfPurchases).FirstOrDefault();
            }
            catch (System.Exception)
            {
                throw new System.Exception("Lỗi khi lấy sản phẩm được mua nhiều nhất");
            }
        }
    }
}