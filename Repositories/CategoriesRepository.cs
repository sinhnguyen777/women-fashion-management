using WomemFashionManagement.Models;
using WomemFashionManagement.Repositories;
using System.Linq;
using WomemFashionManagement.Data;

namespace Repositories.CategoriesRepository
{
  public class CategoriesRepository
  {
    private readonly DataInitializer _dataInitializer;
    public CategoriesRepository()
    {
      _dataInitializer = new DataInitializer();
    }

    public List<Category> GetAllCategories()
    {
      return _dataInitializer.Categories;
    }

    public Category GetCategoryById(int id)
    {
      return _dataInitializer.Categories.FirstOrDefault(c => c.CategoryId == id);
    }

    public List<Category> GetCategoriesByName(string name)
    {
      return _dataInitializer.Categories.Where(c => c.CategoryName.Contains(name)).ToList();
    }

    public void AddCategory(Category category)
    {
      _dataInitializer.Categories.Add(category);
    }

    public void UpdateCategory(Category category)
    {
      var index = _dataInitializer.Categories.FindIndex(c => c.CategoryId == category.CategoryId);
      _dataInitializer.Categories[index] = category;
    }

    public void DeleteCategory(Category category)
    {
      _dataInitializer.Categories.Remove(category);
    }
  }
}
