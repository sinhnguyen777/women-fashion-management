using Repositories.CategoriesRepository;
using Repositories.ProductRepository;

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
            return _productRepository.GetAllProducts();
        }

        public List<ProductDto> GetProductsByCategory(int categoryId)
        {
            var products = _productRepository.GetAllProducts();
            var categories = _categoriesRepository.GetAllCategories();

            var productsByCategory = from p in products
                                     join c in categories on p.CategoryId equals c.CategoryId
                                     where c.CategoryId == categoryId
                                     select p;
            return productsByCategory.ToList();
        }

        public List<ProductDto> GetProductsByCategoryName(string categoryName)
        {
            var products = _productRepository.GetAllProducts();
            var categories = _categoriesRepository.GetAllCategories();

            var productsByCategory = from p in products
                                     join c in categories on p.CategoryId equals c.CategoryId
                                     where c.CategoryName == categoryName
                                     select p;
            return productsByCategory.ToList();
        }

        public ProductDto? GetProductMaxPriceByCategory(string categoryName)
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
    }
}