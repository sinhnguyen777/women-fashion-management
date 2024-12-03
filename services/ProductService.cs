using Repositories.CategoriesRepository;
using Repositories.ProductRepository;
using WomemFashionManagement.Models;

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

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            var products = _productRepository.GetAllProducts();
            var categories = _categoriesRepository.GetAllCategories();

            var productsByCategory = from p in products
                                     join c in categories on p.CategoryId equals c.CategoryId
                                     where c.CategoryId == categoryId
                                     select p;
            return productsByCategory.ToList();
        }

        public List<Product> GetProductsByCategoryName(string categoryName)
        {
            var products = _productRepository.GetAllProducts();
            var categories = _categoriesRepository.GetAllCategories();

            var productsByCategory = from p in products
                                     join c in categories on p.CategoryId equals c.CategoryId
                                     where c.CategoryName == categoryName
                                     select p;
            return productsByCategory.ToList();
        }

        public Product? GetProductMaxPriceByCategory(string categoryName)
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