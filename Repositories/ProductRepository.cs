using WomemFashionManagement.Models;
using WomemFashionManagement.Repositories;
using System.Linq;

namespace Repositories
{
  public class ProductRepository : BaseRepository<Product>
  {
    public List<Product> GetAllProducts()
    {
      return _entities;
    }

    public Product GetProductById(int id)
    {
      return _entities.FirstOrDefault(p => p.ProductId == id);
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
      return _entities.Where(p => p.CategoryId == categoryId).ToList();
    }

  }
}