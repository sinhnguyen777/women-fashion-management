using Repositories.CategoriesRepository;
using Repositories.ProductRepository;
using WomemFashionManagement.Dto;

namespace services.Implementations
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoriesRepository _categoriesRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
            _categoriesRepository = new CategoriesRepository();
        }

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
    }
}