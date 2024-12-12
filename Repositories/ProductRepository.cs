using WomemFashionManagement.Models;
using WomemFashionManagement.Repositories;
using System.Linq;
using WomemFashionManagement.Data;

namespace Repositories.ProductRepository
{
  public class ProductRepository : BaseRepository<ProductDto>
  {
    private readonly DataInitializer _dataInitializer;
    public ProductRepository()
    {
      _dataInitializer = new DataInitializer();
    }

    public List<ProductDto> GetAllProducts()
    {
      var products = _dataInitializer.Products;
      var productAttributes = _dataInitializer.ProductAttributes;

      var resultList = from p in products
                       join pa in productAttributes on p.ProductId equals pa.ProductId
                       select new ProductDto(
                         p.ProductId,
                         p.ProductName,
                         p.Price,
                         p.Quantity,
                         p.CategoryId,
                         pa.Size,
                         pa.Color
                       );

      return resultList.ToList();
    }

    public Product GetProductById(int id)
    {
      return _dataInitializer.Products.FirstOrDefault(p => p.ProductId == id);
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
      return _dataInitializer.Products.Where(p => p.CategoryId == categoryId).ToList();
    }

    public void AddProduct(Product product)
    {
      _dataInitializer.Products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
      var index = _dataInitializer.Products.FindIndex(p => p.ProductId == product.ProductId);
      _dataInitializer.Products[index] = product;
    }

    public void DeleteProduct(Product product)
    {
      _dataInitializer.Products.Remove(product);
    }

  }
}